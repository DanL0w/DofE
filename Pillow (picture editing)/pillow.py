import PIL
from PIL import Image

def xcords(widthIt, width):
    if widthIt == 0:
        xcords = ["skip", "skip", 0, 1, 2]
    elif widthIt == 1:
        xcords = ["skip", 0, 1, 2, 3]
    elif widthIt == width-1:
        xcords = [(width - 3), (width - 2), (width - 1), "skip", "skip"]
    elif widthIt == width-2:
        xcords = [(width - 4), (width - 3), (width - 2), (width - 1), "skip"]
    else:
        xcords = [(widthIt - 2), (widthIt - 1), widthIt, (widthIt + 1), (widthIt + 2)]
    return xcords

def ycords(heightIt, height):
    if heightIt == 0:
        ycords = ["skip", "skip", 0, 1, 2]
    elif heightIt == 1:
        ycords = ["skip", 0, 1, 2, 3]
    elif heightIt == height-1:
        ycords = [(height - 3), (height - 2), (height - 1), "skip", "skip"]
    elif heightIt == height-2:
        ycords = [(height - 4), (height - 3), (height - 2), (height - 1), "skip"]
    else:
        ycords = [(heightIt - 2), (heightIt - 1), heightIt, (heightIt + 1), (heightIt + 2)]
    return ycords

def relGrad(pixel, heightIt, widthIt, height, width, pixelsArray):
    relGrad = False
    ycordsarray = ycords(heightIt, height)
    xcordsarray = xcords(widthIt, width)
    for i in range(3):
        for j in range(3):
                ycord = ycordsarray[i+1]
                xcord = xcordsarray[j+1]
                if xcord == "skip" or ycord == "skip":
                    pass
                else:
                    compPixel = pixelsArray[ycord][xcord]
                    RGrad = abs(compPixel[0]-pixel[0])
                    GGrad = abs(compPixel[1] - pixel[1])
                    BGrad = abs(compPixel[2] - pixel[2])
                    if RGrad > 20:
                        relGrad = True
                    if GGrad > 20:
                        relGrad = True
                    if BGrad > 20:
                        relGrad = True

    return relGrad

def getPixels():
    picture = Image.open("Canal.jfif", "r")
    pixelsList = list(picture.getdata())
    width, height = picture.size

    pixelsArray = []
    pixelcounter = 0
    for heightIt in range(height):
        Row = []
        for widthIt in range(width):
            pixel = pixelsList[pixelcounter]
            pixelcounter = pixelcounter + 1
            Row.append(pixel)
        pixelsArray.append(Row)
    picture.close()
    return pixelsArray, width, height

def outline():
    pixelsArray, width, height = getPixels()

    relGradArray = []
    for heightIt in range(height):
        relGradRow =[]
        for widthIt in range(width):
            pixel = pixelsArray[heightIt][widthIt]
            relGradint = relGrad(pixel, heightIt, widthIt, height, width, pixelsArray)
            relGradRow.append(relGradint)
        relGradArray.append(relGradRow)

    gradlines = Image.new(mode="RGB", size = (width, height), color = (255, 255, 255))
    for heightIt in range(height):
        for widthIt in range(width):
            if (relGradArray[heightIt][widthIt]):
                gradlines.putpixel((widthIt, heightIt), (0,0,0))

    gradlines.show()

def averageRGB(pixelsArray, height, width):
    averageRGBArray = []
    for heightIt in range(height):
        averageRGBRow =[]
        for widthIt in range(width):
            pixel = pixelsArray[heightIt][widthIt]
            averageRGBInt = int((pixel[0] + pixel[1] + pixel[2])/3)
            averageRGBRow.append(averageRGBInt)
        averageRGBArray.append(averageRGBRow)
    return averageRGBArray

def grayscale():
    pixelsArray, width, height = getPixels()

    averageRGBArray = averageRGB(pixelsArray, height, width)

    grayscale = Image.new(mode="RGB", size = (width, height))
    for heightIt in range(height):
        for widthIt in range(width):
            grayscale.putpixel((widthIt, heightIt), (averageRGBArray[heightIt][widthIt],averageRGBArray[heightIt][widthIt],averageRGBArray[heightIt][widthIt]))

    grayscale.show()


def stain():
    pixelsArray, width, height = getPixels()
    averageRGBArray = averageRGB(pixelsArray, height, width)

    grayscale = Image.new(mode="RGB", size = (width, height))
    for heightIt in range(height):
        for widthIt in range(width):
            grayscale.putpixel((widthIt, heightIt), (int(averageRGBArray[heightIt][widthIt] + 0.2*(255 - averageRGBArray[heightIt][widthIt])),averageRGBArray[heightIt][widthIt],int(averageRGBArray[heightIt][widthIt] - 0.2*(255 - averageRGBArray[heightIt][widthIt]))))

    grayscale.show()

def blur():
    pixelsArray, width, height = getPixels()

    blur = Image.new(mode="RGB", size = (width, height))
    for heightIt in range(height):
        for widthIt in range(width):
            ycordsarray = ycords(heightIt, height)
            xcordsarray = xcords(widthIt, width)
            averageR = 0
            averageG = 0
            averageB = 0
            for i in range(5):
                for j in range(5):
                        ycord = ycordsarray[i]
                        xcord = xcordsarray[j]
                        if xcord == "skip" or ycord == "skip":
                            pass
                        else:
                            compPixel = pixelsArray[ycord][xcord]
                            averageR = averageR + compPixel[0]
                            averageG = averageG + compPixel[1]
                            averageB = averageB + compPixel[2]
            averageR = averageR/25
            averageG = averageG/25
            averageB = averageB/25
            blur.putpixel((widthIt, heightIt), (int(averageR), int(averageG), int(averageB)))
    blur.show()

def redeyeAutoRemoval(TLx, TLy, BRx, BRy):
    pixelsArray, width, height = getPixels()
    xLength = BRx-TLx
    yHeight = BRy-TLy
    redeye = Image.new(mode="RGB", size = (width, height))
    for heightIt in range(height):
        for widthIt in range(width):
            pixel = pixelsArray[heightIt][widthIt]
            redeye.putpixel((widthIt, heightIt), (int(pixel[0]), int(pixel[1]), int(pixel[2])))

    for heightIt in range(yHeight):
        for widthIt in range(xLength):
            pixel = pixelsArray[heightIt+TLy][widthIt+TLx]
            if (pixel[0] > 0):
                redeye.putpixel((widthIt, heightIt), (0, 0, 0))
            else:
                redeye.putpixel((widthIt, heightIt), (int(pixel[0]), int(pixel[1]), int(pixel[2])))

    redeye.show()

if __name__ == "__main__":
    outline()