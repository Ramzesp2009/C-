class DatabaseReader
{
    public int? numercValue = null;
    public bool? boolValue = true;
    public int? GetIntFromDatabase()
    {
        return numercValue;
    }
    public bool? GetBoolFromDatabase()
    {
        return boolValue;
    }
}