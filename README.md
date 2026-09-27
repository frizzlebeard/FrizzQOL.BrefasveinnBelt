# FrizzQOL Bréfasveinn Belt

Adds the Bréfasveinn Belt. Craft it at a Forge. While it is equipped, you can take ores, metals, and other blocked items through portals.

## Recipe

- 10 Iron
- 5 Deer Hide
- 3 Silver
- 1 Surtling Core

The belt does not add carry weight. You cannot wear it and Megingjord at the same time.

There is no config file.

## Multiplayer

Every player and the server need this mod, on the same minor version.

## Install

Install with r2modman or the Thunderstore Mod Manager.

To install by hand, copy `FrizzQOL.BrefasveinnBelt.dll` into `BepInEx/plugins`.

## Requirements

- Valheim
- [BepInExPack for Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/)
- [Jotunn](https://thunderstore.io/c/valheim/p/ValheimModding/Jotunn/)

## License

[MIT](LICENSE). You can use, copy, change, and share this mod. Keep the copyright notice with any copy.

## Building

1. Copy `Environment.props.example` to `Environment.props`.
2. Set your Valheim and BepInEx folders in that file.
3. From this folder, run:

```
dotnet build BrefasveinnBelt.sln -c Release
```

The plugin file is `FrizzQOL.BrefasveinnBelt.dll`, under the project `bin\Release\net48` folder.

`Environment.props` stays on your machine. It is listed in `.gitignore`.

## Source

https://github.com/frizzlebeard/FrizzQOL.BrefasveinnBelt
