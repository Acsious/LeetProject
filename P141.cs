namespace LeetProject;

public static class P141
{
    public static bool HasCycle(ListNode head)
    {
        HashSet<ListNode> cycle = new();
        while (head != null)
        {
            if (cycle.Contains(head)) 
            { 
                return true;
            }
            cycle.Add(head);
            head = head.next;
        }
        return false;
    }
}
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}
