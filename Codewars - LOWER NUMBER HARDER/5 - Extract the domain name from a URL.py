def domain_name(url):
    www = url.find("www.")
    slash =  url.find("//")
    if www > slash:
        end = url.find(".", www+4)
        return url[www+4:end]
    elif www == slash == -1:
        end = url.find(".")
        return url[:end]
    else:
        end = url.find(".", slash+2)
        return url[slash+2:end]