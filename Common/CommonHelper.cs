using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CommonHelper
    {
        private void BuildTree<T>(List<T> data, ref List<T> trees) where T : BaseTree<T, int>
        {
            if (data.Any())
            {

                var parents = data.Where(x => x.ParentId == null).ToList();

                foreach (var item in parents)
                {
                    var childrens = data.Where(x => x.ParentId == item.Id).ToList();
                    if (childrens.Any())
                    {
                        item.Children = childrens;
                        trees.Add(item);
                        BuildTree<T>(childrens, ref trees);
                    }
                }
            }
        }
    }
}
