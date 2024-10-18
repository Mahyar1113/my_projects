import xml.etree.ElementTree as ET
#import the path of the XML file as input
def count_images(varzesh3):
    tree = ET.parse(varzesh3)
    root = tree.getroot()

    image_count = 0

    # Find all image tags in the XML file
    for element in root.iter("jpg"):
        image_count += 1

    return image_count

# Provide the path to your XML file
xml_file_path = "varzesh3.xml"

# Call the function to count the number of image tags in the XML file
image_count = count_images(xml_file_path)
print(f"Number of image tags: {image_count}")

