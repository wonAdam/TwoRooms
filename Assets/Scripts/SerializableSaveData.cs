
[System.Serializable]
public class Data
{
    public char Room;
    public int level;
    public int book;

    public Data(char room, int _level, int _book = 0)
    {
        Room = room; level = _level; book = _book;
    }

}
