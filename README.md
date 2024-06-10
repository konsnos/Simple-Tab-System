# Simple Tab System

A simple tab system for fast integration.


## Usage

The package includes two small classes `TabButton` and `TabSystem`.

`TabButton` requires components `Image` and `Button`. It controls the colors of the image depending on the state of the tab. It also keeps a reference for the content to show when selected.

`TabSystem` keeps a reference of all the tabs in the group.

 
## Setup

### Requirements
* Unity 2021.3 or later

### Installation

1. Open the Package Manager from Window > Package Manager.
2. Click the "+" button > Add package from git URL.
3. Enter the following URL:

```
https://github.com/konsnos/Simple-Tab-System.git?path=Assets/SimpleTabSystem
```

Alternatively, open Packages/manifest.json and add the following to the dependencies block:

```json
{
    "dependencies": {
        "com.konsnos.simpletabsystem": "https://github.com/konsnos/Simple-Tab-System.git?path=Assets/SimpleTabSystem"
    }
}
```
