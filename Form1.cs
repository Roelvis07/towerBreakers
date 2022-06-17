using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace towerBreakers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> listilla = new List<int>();

            listilla.Add(100000); listilla.Add(1);       listilla.Add(100000); listilla.Add(1);       listilla.Add(374625); listilla.Add(796723);   listilla.Add(950929); listilla.Add(183477);

            listilla.Add(732159); listilla.Add(779867);  listilla.Add(598794); listilla.Add(596985);  listilla.Add(156054); listilla.Add(445934);   listilla.Add(156030); listilla.Add(99998);

            listilla.Add(58097); listilla.Add(459353);   listilla.Add(866372); listilla.Add(333784);  listilla.Add(601251); listilla.Add(142899);   listilla.Add(708233); listilla.Add(651036);

            listilla.Add(20590); listilla.Add(56425);    listilla.Add(970129); listilla.Add(722162);  listilla.Add(832631); listilla.Add(938765);   listilla.Add(212387); listilla.Add(779);

            listilla.Add(181866); listilla.Add(992436);  listilla.Add(183446); listilla.Add(617621);  listilla.Add(304311); listilla.Add(611791);   listilla.Add(524875); listilla.Add(7068);

            listilla.Add(432043); listilla.Add(23068);   listilla.Add(291295); listilla.Add(524893);  listilla.Add(611991); listilla.Add(399952);   listilla.Add(139526); listilla.Add(46677);

            listilla.Add(292211); listilla.Add(973975);  listilla.Add(366445); listilla.Add(232824);  listilla.Add(456173); listilla.Add(90627);    listilla.Add(785353); listilla.Add(618526);

            listilla.Add(199719); listilla.Add(382549);  listilla.Add(514351); listilla.Add(983453);   listilla.Add(592549); listilla.Add(466869);

            listilla.Add(46461); listilla.Add(860135);   listilla.Add(607682); listilla.Add(680461);   listilla.Add(170563); listilla.Add(450601);  listilla.Add(65067); listilla.Add(13268);

            listilla.Add(949100); listilla.Add(942415);  listilla.Add(965850); listilla.Add(563416);   listilla.Add(808580); listilla.Add(385504);  listilla.Add(304683); listilla.Add(15970);

            listilla.Add(97695); listilla.Add(230946);   listilla.Add(684388); listilla.Add(241080);   listilla.Add(440252); listilla.Add(683418);  listilla.Add(122066); listilla.Add(610135);
            
            listilla.Add(495289); listilla.Add(833383);  listilla.Add(34397); listilla.Add(173404);    listilla.Add(909526); listilla.Add(391149);  listilla.Add(258839); listilla.Add(182278);

            listilla.Add(662672); listilla.Add(755532);  listilla.Add(311782); listilla.Add(425252);   listilla.Add(520186); listilla.Add(207989);  listilla.Add(546834); listilla.Add(567829);

            listilla.Add(184897); listilla.Add(31321);   listilla.Add(969804); listilla.Add(842475);   listilla.Add(775308); listilla.Add(449856);  listilla.Add(939711); listilla.Add(395240);

            listilla.Add(895029); listilla.Add(926868);  listilla.Add(598035); listilla.Add(727436);   listilla.Add(922082); listilla.Add(326615);  listilla.Add(88513); listilla.Add(570573);

            listilla.Add(196028); listilla.Add(520952);  listilla.Add(45238); listilla.Add(961389);    listilla.Add(325404); listilla.Add(844725);  listilla.Add(388765); listilla.Add(747489);

            listilla.Add(271411); listilla.Add(539814);  listilla.Add(828925); listilla.Add(586884);   listilla.Add(356834); listilla.Add(965473);  listilla.Add(280998); listilla.Add(607171);

            listilla.Add(542819); listilla.Add(276062);  listilla.Add(140956); listilla.Add(296341);   listilla.Add(802378); listilla.Add(165305);  listilla.Add(74568); listilla.Add(15640);

            listilla.Add(987110); listilla.Add(423497);  listilla.Add(772419); listilla.Add(394971);   listilla.Add(198761); listilla.Add(293555);  listilla.Add(5524); listilla.Add(14083);

            listilla.Add(815646); listilla.Add(198888);  listilla.Add(707017); listilla.Add(711503);   listilla.Add(729172); listilla.Add(790354);  listilla.Add(771445); listilla.Add(606097);

            listilla.Add(74062); listilla.Add(926510);   listilla.Add(358547); listilla.Add(651224);   listilla.Add(115896); listilla.Add(915166);  listilla.Add(863298); listilla.Add(850231); 
            
            listilla.Add(623439); listilla.Add(449552);  listilla.Add(330973); listilla.Add(95432);    listilla.Add(63573); listilla.Add(370902);   listilla.Add(311053); listilla.Add(668992);

            listilla.Add(325257); listilla.Add(666073);  listilla.Add(729771); listilla.Add(591431);   listilla.Add(637702); listilla.Add(274784);


            //-**************************************lista de resultados**************************************************-//
            List<int> listresults = new List<int>();
            listresults.Add(2);   listresults.Add(2);  listresults.Add(1);  listresults.Add(1);

            listresults.Add(1);   listresults.Add(2);  listresults.Add(2);  listresults.Add(2);

            listresults.Add(1);   listresults.Add(2);  listresults.Add(1);  listresults.Add(1);

            listresults.Add(2);   listresults.Add(1);  listresults.Add(1);  listresults.Add(1);

            listresults.Add(2);   listresults.Add(2);  listresults.Add(1);  listresults.Add(1);

            listresults.Add(1);   listresults.Add(1);  listresults.Add(1);  listresults.Add(2);

            listresults.Add(1);   listresults.Add(1);  listresults.Add(1);  listresults.Add(1);

            listresults.Add(1);   listresults.Add(1);  listresults.Add(1);

            listresults.Add(1);   listresults.Add(2);  listresults.Add(1);  listresults.Add(1);

            listresults.Add(2);   listresults.Add(2);  listresults.Add(2);  listresults.Add(1);

            listresults.Add(1);   listresults.Add(2);  listresults.Add(2);  listresults.Add(2);

            listresults.Add(1);   listresults.Add(1);  listresults.Add(2);  listresults.Add(1);

            listresults.Add(2);   listresults.Add(2);  listresults.Add(2);  listresults.Add(2);

            listresults.Add(1);   listresults.Add(2);  listresults.Add(2);  listresults.Add(1);

            listresults.Add(1);   listresults.Add(1);  listresults.Add(2);  listresults.Add(1);

            listresults.Add(2);   listresults.Add(2);  listresults.Add(2);  listresults.Add(1);

            listresults.Add(1);   listresults.Add(1);  listresults.Add(2);  listresults.Add(2);

            listresults.Add(1);   listresults.Add(2);  listresults.Add(2);  listresults.Add(2);

            listresults.Add(2);   listresults.Add(1);  listresults.Add(1);  listresults.Add(2);

            listresults.Add(2);   listresults.Add(1);  listresults.Add(2);  listresults.Add(1);

            listresults.Add(2);   listresults.Add(1);  listresults.Add(2);  listresults.Add(2);

            listresults.Add(1);   listresults.Add(1);  listresults.Add(1);  listresults.Add(1);

            listresults.Add(1);   listresults.Add(1);  listresults.Add(2);

            int count = 1;
            int count1 = 0;
            for (int i = 0; i < listilla.Count; i+=2)
            {
                int resultados = towerBreakers(listilla[i], listilla[i + 1]);

                if(resultados != listresults[count1])
                {
                    Console.WriteLine(count + "* Error en linea: " + count1 + ", numeros -> " + listilla[i] + " y " + listilla[i + 1] + ", comparativa: resultado-> " + resultados + ", debia ser-> " + listresults[count1]);
                    count++;
                }
                count1++;
            }
        }
        public static int towerBreakers(int n, int m)
        {
            if (n % 2 == 1 && m > 1)
            {
                return 1;
            }
            return 2;

        }
    }
}
