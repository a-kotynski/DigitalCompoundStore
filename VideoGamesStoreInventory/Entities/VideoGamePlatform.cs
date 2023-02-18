namespace DigitalCompoundStoreAPI.Entities;

public enum VideoGamePlatform // https://stackoverflow.com/questions/50375357/how-to-create-a-table-corresponding-to-enum-in-ef-core-code-first
{
    Unknown = 0,
    PC = 1,
    PS1 = 2,
    PS2 = 3,
    PS3 = 4,
    PS4 = 5,
    PS5 = 6,
    PSPortable = 7,
    PSVita = 8,
    Xbox = 9,
    Xbox360 = 10,
    XboxOne = 11,
    XboxSeriesX = 12,
    XboxSeriesS = 13,
    N64 = 14,
    NES = 15,
    SNES = 16,
    DS = 17,
    ThreeDS = 18,
    Switch = 19,
    SegaGenesis = 20,
    SegaSaturn = 21,
}
