using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bleistift.LyricalEditor.Options
{
    public class Detail
    {
        public string RuleRegex { get; set; }
        public int Opacity { get; set; }
        public bool IsRandom { get; set; }
        public bool IsSlideShow { get; set; }
        public decimal SlideShowTiming { get; set; }
        public List<string> Images { get; set; }

        public Detail()
        {
            SlideShowTiming = 0.1M;
            Opacity = 25;
            Images = new List<string>();
        }

        public override string ToString()
        {
            var half = string.Join("\t", new object[] { RuleRegex ?? "", Opacity, IsRandom, IsSlideShow, SlideShowTiming });
            return half + "\t" + string.Join("\t", Images ?? new List<string>());
        }

        public static string Str(List<Tuple<string, Detail>> details)
        {
            return string.Join("\n", details.Select(d => d.Item1 + "\t" + d.Item2.ToString()));
        }

        public static List<Tuple<string, Detail>> Details(string details)
        {
            return details.Split(new[]{'\n'}, StringSplitOptions.RemoveEmptyEntries).Select(d =>
                {
                    var kv = d.Split(new[] { '\t' }, 2);
                    return Tuple.Create(kv[0], ValueOf(kv[1]));
                }).ToList();
        }

        private static Detail ValueOf(string d)
        {
            var elems = d.Split('\t');
            var det = new Detail
            {
                RuleRegex = elems[0],
                Opacity = int.Parse(elems[1]),
                IsRandom = bool.Parse(elems[2]),
                IsSlideShow = bool.Parse(elems[3]),
                SlideShowTiming = decimal.Parse(elems[4]),
                Images = elems.Skip(5).ToList()
            };
            return det;
        }
    }
}
