
[System.Serializable]
public class Data
{
    public char Room;
    public int level;
    public int book;
    public bool interview;

    public Data(char room, int _level, int _book = 0, bool _interview = true)
    {
        Room = room; level = _level; book = _book; interview = _interview;
    }

}
