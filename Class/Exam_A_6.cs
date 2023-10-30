using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_Logical_and_Review_Code.Class
{
    /*class TreeNode
    {
        private readonly List<TreeNode> _children = new List<TreeNode>();
        public void AddChild(TreeNode child)
        {
            _children.Add(child);
        }
    }*/

    class TreeNode
    {
        private readonly List<TreeNode> _children = new List<TreeNode>();
        public IReadOnlyList<TreeNode> Children => _children;
        public void AddChild(TreeNode child)
        {
            _children.Add(child);
        }
        public void RemoveChildAt(int index)
        {
            _children.RemoveAt(index);
        }
    }

}
