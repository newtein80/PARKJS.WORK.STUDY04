using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARKJS.WORK.STUDY04.Models.Actress
{
    public class Acrtess_JP_SearchMV
    {
        // to View
        public List<Actress_JP> actress_JPs;
        public SelectList categoryIds;

        // from View
        public string i_selectedCategory { get; set; }
        public string i_searchString { get; set; }
    }
}
