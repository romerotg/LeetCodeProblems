namespace LeetCodeProblems.Binary_Tree.Conclusion
{
	public class PopulatingNextRightPointersinEachNode
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
				_Connect(root.left, root.right);
		}

		private void _Connect(TreeLinkNode left, TreeLinkNode right)
		{
			if (left == null || right == null)
				return;

			left.next = right;
			_Connect(left.left, left.right);
			_Connect(left.right, right.left);
			_Connect(right.left, right.right);
		}
	}
}
