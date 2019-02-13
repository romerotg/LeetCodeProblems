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
				TreeLinkNode current = root;
				TreeLinkNode currentTemp = root.left;

				while (current != null)
				{
					if (current.left != null && current.right != null)
						current.left.next = current.right;

					if (current.right != null && current.next != null)
					{
						current.right.next = current.next.left;
						current = current.next;
					}
					else
					{
						current = currentTemp;
						if (currentTemp != null)
							currentTemp = currentTemp.left;
					}
				}
			}
		}
	}
}
