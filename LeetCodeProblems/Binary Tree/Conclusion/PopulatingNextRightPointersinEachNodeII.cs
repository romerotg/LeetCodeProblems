namespace LeetCodeProblems.Binary_Tree.Conclusion
{
	public class PopulatingNextRightPointersinEachNodeII
	{
		public class TreeLinkNode
		{
			public int val;
			public TreeLinkNode left;
			public TreeLinkNode right;
			public TreeLinkNode next;
			public TreeLinkNode(int x) { val = x; }
		}

		public void Connect(TreeLinkNode root)
		{
			if (root != null)
			{
				if (root.left != null && root.right != null)
				{
					root.left.next = root.right;
					root.right.next = _GetClosestChildNodeToTheRight(root.next);
					Connect(root.right);
					Connect(root.left);
				}
				else if (root.left != null)
				{
					root.left.next = _GetClosestChildNodeToTheRight(root.next);
					Connect(root.left);
				}
				else if (root.right != null)
				{
					root.right.next = _GetClosestChildNodeToTheRight(root.next);
					Connect(root.right);
				}
			}
		}

		private TreeLinkNode _GetClosestChildNodeToTheRight(TreeLinkNode node)
		{
			if (node == null)
				return null;

			if (node.left != null)
				return node.left;

			if (node.right != null)
				return node.right;

			return _GetClosestChildNodeToTheRight(node.next);
		}
	}
}
