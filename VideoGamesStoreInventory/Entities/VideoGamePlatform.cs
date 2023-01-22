namespace VideoGamesStoreInventory.Entities;

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
    XBOX = 9,
    XBOX360 = 10,
    XBOXOne = 11,
    XBOXSeriesX = 12,
    XBOXSeriesS = 13,
    N64 = 14,
    NES = 15,
    SNES = 16,
    DS = 17,
    ThreeDS = 18,
    Switch = 19,
    SegaGenesis = 20,
    SegaSaturn = 21,
}
