# Simple Tab System

A simple tab system for fast integration.


## Usage

`TabButton` requires components `Image` and `Button`. It controls the colors of the image depending on the state of the tab. It also keeps a reference for the content to show when selected.

`TabSystem` keeps a reference of all the tabs in the group.

### Tab Persistence

`TabSystemMemory` class persists the selected tab using Unity's PlayerPrefs. It creates a persistence key by combining a constant prefix with the GameObject name. **Make sure the GameObject name is unique across the scene** to avoid conflicts. The persisted tab index is automatically loaded at startup and updated as the active tab changes.

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
