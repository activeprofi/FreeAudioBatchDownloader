# Project description and functionality 

## Short description
FABD(Free Audio Batch Downloader) is a program 
which help to batch download a large list of files.
Files type or extensions are  different.

### User case:
  - User have an URL address.
  - He goes to that address and open in browser.
  - In that HTML page is a large list of link and every link lead to the file.
  - User can click on every link to download file on his computer.

#### What program do:
  1. When program is starting it ask a few questions:
      - Enter URL address.	      
	  - Enter file extension to download.
	  - Enter the address of a folder on your computer to which the program can load all files with this extension.

  2. Separate URL and extract some parts to concatenate together:
	  - scheme (http or https)
	  - : / /
	  - domain name
	  - port
      >Or if tell simply: extract part of URL without path to file and parameters and anchor.

  3. Program download full HTML code/page.
  4. Parse this page and find all ```<a href="...">...</a>``` tags.
  5. Save every href to a list or an array.
      - Modify each href before or after saving to add scheme + domain + port in the beginning.
  6. Start download each file from list to user's PC into entering path before.	
  7. The end.

## Entities in Model  
  - Web-page:
    - URL address
    - HTML code

  - Each file:
    - File type/extension
	- Full file URL address
	- Full file path on the PC
  
  - List of the files

  - Folder:
    - Path to the folder on PC
    - List of files in the folder
