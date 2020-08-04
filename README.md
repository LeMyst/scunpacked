![Build](https://github.com/richardthombs/scunpacked/workflows/Build/badge.svg)

## Extracting data from Star Citizen

Create a folder to store the extracted Star Citizen data:

```
mkdir c:\scdata\3.7.2
```

Download and run the [extraction tools](https://github.com/dolkensp/unp4k):

```
cd c:\scdata\3.7.2
unp4k.exe 'C:\Program Files\Roberts Space Industries\StarCitizen\LIVE\Data.p4k' *.xml
unp4k.exe 'C:\Program Files\Roberts Space Industries\StarCitizen\LIVE\Data.p4k' *.ini
unforge.exe .
```

Run the loader:

```
loader.exe -scdata=c:\scdata\3.7.2 -output=c:\scdata\3.7.2-json
```

Now you will have a folder `c:\scdata\3.7.2-json` which contains:

```
items        - Folder containing all Items, named after the class name
loadouts     - Folder containing loadouts for ships and items named after the loadout filename
ships        - Folder containing all ships, named after the class name
items.json   - Index of all the items
labels.json  - English translations of all labels
ships.json   - Index of all the ships
shops.json   - Index of all shops and everything that they sell or buy
```
