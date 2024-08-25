namespace LeetProject;

internal class P155
{
    List<int> list;
    public P155()
    {
        list = [];
    }

    public void Push(int val)
    {
        list.Add(val);
    }

    public void Pop()
    {
        list.RemoveAt(list.Count - 1);
    }

    public int Top()
    {
        return list[^1];
    }

    public int GetMin()
    {
        List<int> l = list;
        l.Sort();
        list.Remove(l[0]);
        return l[0];
    }
}
