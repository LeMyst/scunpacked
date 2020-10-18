![Build](https://github.com/LeMyst/scunpacked/workflows/Build/badge.svg)

## Extracting data from Star Citizen

Create a folder to store the extracted Star Citizen data:

```
mkdir c:\scdata\3.7.2
```

Download and run Peter Dolkens' excellent [extraction tools](https://github.com/dolkensp/unp4k):

```
cd c:\scdata\3.7.2
unp4k.exe 'C:\Program Files\Roberts Space Industries\StarCitizen\LIVE\Data.p4k' *.xml
unp4k.exe 'C:\Program Files\Roberts Space Industries\StarCitizen\LIVE\Data.p4k' *.ini
unforge.exe .
```

Run the loader:

```
loader.exe --input=c:\scdata\3.7.2 --output=c:\scdata\3.7.2-json
```
> Note: The loader will take a while to run as it now loads virtually every in-game item

You will now have a folder `c:\scdata\3.7.2-json` which contains:

```
ammo/              - Folder containing the json for each type of ammunition
items/             - Folder containing the json for each item in Star Citizen, named after the class name (there are a lot)
loadouts/          - Folder containing loadouts for ships and items named after the loadout filename (CIG seem to be moving away from loadout files)
ships/             - Folder containing the json for each ships, named after the class name
ammo.json          - Index of all the ammunition fired by weapons and countermeasures
fps-items.json     - Index of player equipment
items.json         - Index of pretty much all the items in Star Citizen (this is quite large)
labels.json        - English translations of all labels
manufacturers.json - Index of all the manufacturers in the game
ship-items.json    - Index of ship equipment
ships.json         - Index of all the ships
shops.json         - Index of all shops and everything that they sell or buy
starmap.json       - Index of the locations in the star map
```

## How to use it
It is up to you! But to give you a starting point, the scunpacked website uses `ships.json`, `ship-items.json` and `fps-items.json` to construct menus and lists. Then it loads more detailed information, item-by-item as they needed from `items/<itemname>.json`.

> If you are publishing a derrivative work, don't forget to include the CIG attribution & disclaimer that they require you to use!

## Credits
- [unp4k](https://github.com/dolkensp/unp4k) by [Peter Dolkens](https://github.com/dolkensp)
