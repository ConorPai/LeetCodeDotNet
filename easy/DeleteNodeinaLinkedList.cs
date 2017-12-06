//https://leetcode.com/problems/delete-node-in-a-linked-list/description/

public class DeleteNodeinaLinkedListDemo {
    public void DeleteNode(ListNode node) {
        if(node != null && node.next != null) {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}