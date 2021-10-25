# fdvs
File Delivery Validation System (FDVS) is an open source software designed to aid with large scale file deliveries.
The purpose of the software is to validate the content of a folder meant for delivery by checking if the files requested by an item list exists within the delivery folder structure.

**STEPS:**

- Step 1: Import the delivery item list from a single column long .csv, .xlsx, or .xml file.
- Step 2: Specify which folder structure that encapsulates the delivery.
- Step 3: Validate that the expected files requested by the item list exists within the folder structure.
- Step 4: Export a pdf or excel sheet containing the delivery specifications.

**Example of item list deliverables (program input):**

![Concept Input](https://github.com/RasmusBroborg/fdvs/blob/main/Assets/ReadMe/InputValuesExample.png)

**Example of output data after running program (program output):**

![Concept Output](https://github.com/RasmusBroborg/fdvs/blob/main/Assets/ReadMe/OutputValuesExample.png)

In the above example the program detected all files except the expected files for the Finnish deliverables, 
which in this case were incorrectly named with double file extensions at the end of their filename. 
In a delivery scenario the error would be easily detectable and fixed before the delivery is sent to the
client.
