# File Delivery Validation System
File Delivery Validation System (FDVS) is an open source tool designed to aid with large scale file deliveries by autogenerating delivery documentation of a specific delivery folder. If an itemized order list of deliverables exists the program can also cross reference the contents of the delivery folder with the list to ensure that all expected files exists within the folder and its subfolders.

**CONCEPTUAL STEPS:**

- Step 1: Import the delivery item list from a single column long .csv, .xlsx, or .xml file.
- Step 2: Specify which folder structure that encapsulates the delivery.
- Step 3: Validate that the expected files requested by the item list exists within the folder structure.
- Step 4: Export a pdf or excel sheet containing the delivery specifications.

**Example of an itemised list of deliverables (program input):**

![Concept Input](https://github.com/RasmusBroborg/fdvs/blob/main/Assets/ReadMe/InputValuesExample.png)

**Example of output data after running the program (program output):**

![Concept Output](https://github.com/RasmusBroborg/fdvs/blob/main/Assets/ReadMe/OutputValuesExample.png)

In the above example the program detected all files except the Finnish deliverables, 
which in this case were incorrectly named with double file extensions at the end of their filename. 
As the filenames did not match the expected names in the itemised list of deliverables they instead show 
up in the column labeled Extra Files.
