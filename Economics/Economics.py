import csv, math
from datapackage import Package
import matplotlib.pyplot as plt


def get_file_download(datatype):
    package = Package(f'https://datahub.io/core/{datatype}/datapackage.json')
    for resource in package.resources:
        if resource.descriptor['datahub']['type'] == 'derived/csv':
            return resource.read()


def get_file_local(datatype):
    dataset = []
    with open(f'{datatype}_csv.csv', mode='r') as file:
        csvFile = csv.reader(file)
        for entry in csvFile:
            if entry[2] != "Year":
                new_entry = entry[0:2]
                new_entry.append(int(entry[2]))
                new_entry.append(float(entry[3]))
                dataset.append(new_entry)
    return dataset


def linear_regression(x_values, y_values):
    if len(x_values) != len(y_values):
        return False
    n = len(x_values)
    sum_x = sum(x_values)
    sum_y = sum(y_values)
    sum_x_p2 = 0
    for x in x_values:
        sum_x_p2 += math.pow(x,2)
    sum_xy = 0
    for i in range(n):
        sum_xy += x_values[i] * y_values[i]
    y_intercept = ((sum_y * sum_x_p2) - (sum_x * sum_xy)) / ((n * sum_x_p2) - math.pow(sum_x, 2))
    x_coefficient = ((n * sum_xy) - (sum_x * sum_y)) / ((n * sum_x_p2) - math.pow(sum_x, 2))
    return y_intercept, x_coefficient


def correlation_coefficient_standard_deviations(x_values, y_values):
    N = len(x_values)
    x_average = sum(x_values) / len(x_values)
    y_average = sum(y_values) / len(y_values)
    sum_x_minus_av_x_times_y_minus_av_y = 0
    sum_x_minus_av_x_squared = 0
    sum_y_minus_av_y_squared = 0
    for i in range(N):
        sum_x_minus_av_x_times_y_minus_av_y += (x_values[i] - x_average)*(y_values[i] - y_average)
        sum_x_minus_av_x_squared += math.pow((x_values[i] - x_average), 2)
        sum_y_minus_av_y_squared += math.pow((y_values[i] - y_average), 2)
    correlation_coefficient = sum_x_minus_av_x_times_y_minus_av_y / math.pow((sum_x_minus_av_x_squared * sum_y_minus_av_y_squared), 0.5)
    standard_deviation_x = math.pow((sum_x_minus_av_x_squared / N), 0.5)
    standard_deviation_y = math.pow((sum_y_minus_av_y_squared / N), 0.5)
    return correlation_coefficient, standard_deviation_x, standard_deviation_y



def data_cleaning(dataset, earliest_year):
    current_country_code = ""
    last_entry_year = int
    current_country_array = []
    cleaned_dataset = []
    for entry in dataset:
        if entry[1] != current_country_code:
            cleaned_dataset.append(current_country_array)
            current_country_array = []
            current_country_code = entry[1]
            if entry[2] != earliest_year:
                for i in range(entry[2] - earliest_year):
                    current_country_array.append([entry[0], entry[1], 1960+i, "n/a"])
        elif entry[2] != last_entry_year + 1:
            for i in range(entry[2] - (last_entry_year + 1)):
                current_country_array.append([entry[0], entry[1], (last_entry_year + 1) + i, "n/a"])
        current_country_array.append(entry)
        last_entry_year = entry[2]
    return cleaned_dataset[1:]


def differentiate(dataset):
    differentiated_data = []
    for country in dataset:
        country_differentiated = []
        last_value = "n/a"
        for entry in country:
            if last_value == "n/a" or entry[3] == "n/a":
                country_differentiated.append([entry[0], entry[1], entry[2], "n/a"])
            else:
                country_differentiated.append([entry[0], entry[1], entry[2], (float(entry[3]) / float(last_value)) - 1])
            last_value = entry[3]
        differentiated_data.append(country_differentiated)
    return differentiated_data


def percent_to_decimal(dataset):
    converted_data = []
    for country in dataset:
        converted_country = []
        for entry in country:
            if entry[3] != "n/a":
                converted_country.append([entry[0], entry[1], entry[2], float(entry[3]) / 100])
            else:
                converted_country.append(entry)
        converted_data.append(converted_country)
    return converted_data


def find_earliest_year(datasets):
    current_earliest_year = 2100
    for dataset in datasets:
        for entry in dataset:
            if entry[2] < current_earliest_year:
                current_earliest_year = entry[2]
    return current_earliest_year


def find_country_data(country_code, dataset):
    country_data = []
    for country in dataset:
        for entry in country:
            if entry[1] == country_code:
                country_data.append(entry)
    return country_data


def find_years_with_data(dataset_1, dataset_2):
    dataset_1_common_year_entries, dataset_2_common_year_entries = [], []
    for (entry_1, entry_2) in zip(dataset_1, dataset_2):
        if (entry_1[3] != "n/a") and (entry_2[3] != "n/a"):
            dataset_1_common_year_entries.append(entry_1)
            dataset_2_common_year_entries.append(entry_2)
    return dataset_1_common_year_entries, dataset_2_common_year_entries


def get_data_only(dataset):
    data_only_array = []
    for entry in dataset:
        data_only_array.append(float(entry[3]))
    return data_only_array


if __name__ == "__main__":
    #  uncomment the next line to use local files
    tables_raw = [get_file_local("gdp"), get_file_local("cpi"), get_file_local("inflation"), get_file_local("population")]

    #  uncomment the next line to download files, this will take a while to run each time
    #  don't use at the same time as local files above
    #  don't use currently as the get_file_download method is configured to be compatible with the datafile structure at
    #  the time the program ws written and needs reworking to be compatible with the data as it is currently downloaded

    #tables_raw = [get_file_download("gdp"), get_file_download("cpi"), get_file_download("inflation"), get_file_download("population")]

    earliest_year = find_earliest_year(tables_raw)

    tables_cleaned = []
    for table in tables_raw:
        tables_cleaned.append(data_cleaning(table, earliest_year))

    GDP = differentiate(tables_cleaned[0])
    CPI = differentiate(tables_cleaned[1])
    inflation = percent_to_decimal(tables_cleaned[2])
    population = differentiate(tables_cleaned[3])

    country = input("Enter the code of the country you want to view data for:")

    datadict = {"GDP": find_country_data(country, GDP), "CPI": find_country_data(country, CPI), "Inflation": find_country_data(country, inflation), "Population": find_country_data(country, population)}
    country_GDP = find_country_data(country, GDP)
    country_CPI = find_country_data(country, CPI)
    country_inflation = find_country_data(country, inflation)
    country_population = find_country_data(country, population)

    vars_invalid = True
    while vars_invalid:
        try:
            var_1 = datadict[input("Enter the name of the 1st the variable you would like compared: (GDP, CPI, Inflation (non-CPI), Population)")]
            var_2 = datadict[input("Enter the name of the 2nd the variable you would like compared: (GDP, CPI, Inflation (non-CPI), Population)")]
            vars_invalid = False
        except:
            print("Enter a valid values")

    years_with_data_present_1, years_with_data_present_2 = find_years_with_data(var_1, var_2)

    values_only_1 = get_data_only(years_with_data_present_1)
    values_only_2 = get_data_only(years_with_data_present_2)

    linear_regression = linear_regression(values_only_1, values_only_2)
    print(f"Y-intercept: {linear_regression[0]} X-coefficient: {linear_regression[1]}")
    correlation_coefficient, standard_deviation_1, standard_deviation_2 = correlation_coefficient_standard_deviations(values_only_1, values_only_2)
    print(f"The correlation coefficient is {correlation_coefficient}")
    print(f"{math.pow(correlation_coefficient, 2)} of the change in either variable can therefore be explained by the other, this is not the same as causation")
    print(f"The standard deviation of the first dataset is {standard_deviation_1}")
    print(f"The standard deviation of the first dataset is {standard_deviation_2}")
    plt.scatter(values_only_1, values_only_2)
    plt.show()
