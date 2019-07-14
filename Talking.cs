using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace talkwith_spulpa
{
    internal class Talking
    {
        public String name { get; set; }
        public String talk { get; set; }
        public Talking(
            String name,
            String talk
            )
        {
            this.talk = talk;
            this.name = name;
        }
    }

    internal class TalkTable : ClassMap<Talking>
    {
        private TalkTable()
        {
            Map(c => c.name).Index(0);
            Map(c=> c.talk).Index(1);
        }
    }



}
