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
			{
				if (root.left != null && root.right != null)
				{
					root.left.next = root.right;

					if (root.next != null)
						root.right.next = root.next.left;

					Connect(root.right);
					Connect(root.left);
				}
			}
		}
	}
}
