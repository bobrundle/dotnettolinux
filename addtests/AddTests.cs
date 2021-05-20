using System;
using Xunit;
using add;
using System.IO;

namespace AddTests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(new string[] {}, "0",0)]
        [InlineData(new string[] {"1","2","3"}, "6",0)]
        [InlineData(new string[] {"1","2","a"}, "",1)]
        [InlineData(new string[] {"1.1","2.2","3.3"}, "6.6",0)]
        [InlineData(new string[] {"-1e6","1e6"}, "0",0)]
        public void MainTest(string[] args0, string r0, int e0)
        {
            string outfile = Path.GetTempFileName();
            var outstream = File.CreateText(outfile);
            Console.SetOut(outstream);
            int e1 = Program.Main(args0);
            Console.Out.Close();
            string r1 = File.ReadAllText(outfile);
            Assert.Equal(e0, e1);
            if(e0 == 0)
            {
                Assert.Equal(r0 + Environment.NewLine,r1);    
            }
        }
    }
}
