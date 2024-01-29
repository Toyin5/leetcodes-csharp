
using System.Text;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
namespace src;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        /**STEPS:
        * 1 - reverse and turn each listnode into a string of it's digit
        * 2 - convert string to integer
        * 3 - perform operation
        * 4 - 
        */

    }

    public ListNode? Reverse(ListNode list)
    {
        ListNode? previous = null;
        ListNode current = list;
        ListNode? next = null;

        while (current != null)
        {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }

    public string ConvertToString(ListNode list)
    {
        StringBuilder result = new StringBuilder("");
        ListNode current = list;
        while (current != null)
        {
            result.Append(current.val);
            current = current.next;
        }
        return result.ToString();
    }
}