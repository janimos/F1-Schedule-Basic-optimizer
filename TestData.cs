using System;
using Distance;
using GranPrix;

namespace TestData
{
    public class TestingData
    {
        public StageList Test1()
        {
            StageList stages = new StageList();

            float[] income1 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage first = new Stage("Sakhir", "Bahrein", income1);
            stages.AddStage(first);

            float[] income2 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage second = new Stage("Jeddah", "Saudi Arabia", income2);
            stages.AddStage(second);

            float[] income3 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage third = new Stage("Melbourne", "Australia", income3);
            stages.AddStage(third);

            stages.AddDistance(first, second, 200);
            stages.AddDistance(first, third, 1000);
            stages.AddDistance(second, third, 900);

            return stages;
        }

        public StageList Test2()
        {
            StageList stages = new StageList();

            float[] income1 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage first = new Stage("Sakhir", "Bahrein", income1);
            stages.AddStage(first);

            float[] income2 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage second = new Stage("Jeddah", "Saudi Arabia", income2);
            stages.AddStage(second);

            float[] income3 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage third = new Stage("Melbourne", "Australia", income3);
            stages.AddStage(third);

            float[] income4 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage fourth = new Stage("Baku", "Azerbaijan", income4);
            stages.AddStage(fourth);

            float[] income5 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage fifth = new Stage("Miami", "United States", income5);
            stages.AddStage(fifth);

            stages.AddDistance(first, second, 200);
            stages.AddDistance(first, third, 1000);
            stages.AddDistance(first, fourth, 400);
            stages.AddDistance(first, fifth, 2000);

            stages.AddDistance(second, third, 900);
            stages.AddDistance(second, fourth, 500);
            stages.AddDistance(second, fifth, 2200);

            stages.AddDistance(third, fourth, 2600);
            stages.AddDistance(third, fifth, 2000);

            stages.AddDistance(fourth, fifth, 1900);

            return stages;
        }

        public StageList Test3()
        {
            StageList stages = new StageList();

            float[] income1 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage first = new Stage("Sakhir", "Bahrein", income1);
            stages.AddStage(first);

            float[] income2 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage second = new Stage("Jeddah", "Saudi Arabia", income2);
            stages.AddStage(second);

            float[] income3 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage third = new Stage("Melbourne", "Australia", income3);
            stages.AddStage(third);

            float[] income4 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage fourth = new Stage("Baku", "Azerbaijan", income4);
            stages.AddStage(fourth);

            float[] income5 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage fifth = new Stage("Miami", "United States", income5);
            stages.AddStage(fifth);

            float[] income6 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage sixth = new Stage("Imola", "Italy", income6);
            stages.AddStage(sixth);

            float[] income7 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage seventh = new Stage("Monaco", "Monaco", income7);
            stages.AddStage(seventh);

            float[] income8 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage eigth = new Stage("Barcelona", "Spain", income8);
            stages.AddStage(eigth);

            float[] income9 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage ninth = new Stage("Montreal", "Canada", income9);
            stages.AddStage(ninth);

            float[] income10 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage tenth = new Stage("Red Bull Ring", "Austria", income10);
            stages.AddStage(tenth);

            stages.AddDistance(first, second, 200);
            stages.AddDistance(first, third, 1000);
            stages.AddDistance(first, fourth, 400);
            stages.AddDistance(first, fifth, 2000);
            stages.AddDistance(first, sixth, 600);
            stages.AddDistance(first, seventh, 800);
            stages.AddDistance(first, eigth, 900);
            stages.AddDistance(first, ninth, 2500);
            stages.AddDistance(first, tenth, 900);

            stages.AddDistance(second, third, 900);
            stages.AddDistance(second, fourth, 500);
            stages.AddDistance(second, fifth, 2200);
            stages.AddDistance(second, sixth, 700);
            stages.AddDistance(second, seventh, 900);
            stages.AddDistance(second, eigth, 1000);
            stages.AddDistance(second, ninth, 2700);
            stages.AddDistance(second, tenth, 1000);

            stages.AddDistance(third, fourth, 2600);
            stages.AddDistance(third, fifth, 2000);
            stages.AddDistance(third, sixth, 900);
            stages.AddDistance(third, seventh, 500);
            stages.AddDistance(third, eigth, 6200);
            stages.AddDistance(third, ninth, 3000);
            stages.AddDistance(third, tenth, 740);

            stages.AddDistance(fourth, fifth, 1900);
            stages.AddDistance(fourth, sixth, 800);
            stages.AddDistance(fourth, seventh, 630);
            stages.AddDistance(fourth, eigth, 2350);
            stages.AddDistance(fourth, ninth, 860);
            stages.AddDistance(fourth, tenth, 1700);

            stages.AddDistance(fifth, sixth, 1000);
            stages.AddDistance(fifth, seventh, 3025);
            stages.AddDistance(fifth, eigth, 456);
            stages.AddDistance(fifth, ninth, 9500);
            stages.AddDistance(fifth, tenth, 600);

            stages.AddDistance(sixth, seventh, 430);
            stages.AddDistance(sixth, eigth, 785);
            stages.AddDistance(sixth, ninth, 2000);
            stages.AddDistance(sixth, tenth, 3000);

            stages.AddDistance(seventh, eigth, 750);
            stages.AddDistance(seventh, ninth, 1000);
            stages.AddDistance(seventh, tenth, 850);

            stages.AddDistance(eigth, ninth, 2400);
            stages.AddDistance(eigth, tenth, 1900);

            stages.AddDistance(ninth, tenth, 500);

            return stages;
        }

        public StageList Test4()
        {
            StageList stages = new StageList();

            float[] income1 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage first = new Stage("Sakhir", "Bahrein", income1);
            stages.AddStage(first);

            float[] income2 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage second = new Stage("Jeddah", "Saudi Arabia", income2);
            stages.AddStage(second);

            float[] income3 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage third = new Stage("Melbourne", "Australia", income3);
            stages.AddStage(third);

            float[] income4 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage fourth = new Stage("Baku", "Azerbaijan", income4);
            stages.AddStage(fourth);

            float[] income5 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage fifth = new Stage("Miami", "United States", income5);
            stages.AddStage(fifth);

            float[] income6 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage sixth = new Stage("Imola", "Italy", income6);
            stages.AddStage(sixth);

            float[] income7 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage seventh = new Stage("Monaco", "Monaco", income7);
            stages.AddStage(seventh);

            float[] income8 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage eigth = new Stage("Barcelona", "Spain", income8);
            stages.AddStage(eigth);

            float[] income9 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage ninth = new Stage("Montreal", "Canada", income9);
            stages.AddStage(ninth);

            float[] income10 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage tenth = new Stage("Red Bull Ring", "Austria", income10);
            stages.AddStage(tenth);

            float[] income11 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage eleven = new Stage("Silverstone", "United Kingdom", income11);
            stages.AddStage(eleven);

            float[] income12 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage twelwe = new Stage("Budapest", "Hugary", income12);
            stages.AddStage(twelwe);

            float[] income13 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage thirteen = new Stage("Spa", "Belgium", income13);
            stages.AddStage(thirteen);

            float[] income14 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage fourteenth = new Stage("Zandvoort", "Netherlands", income14);
            stages.AddStage(fourteenth);

            float[] income15 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage fifteenth = new Stage("Monza", "Italy", income15);
            stages.AddStage(fifteenth);

            float[] income16 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage sixteenth = new Stage("Singapore", "Singapore", income16);
            stages.AddStage(sixteenth);

            float[] income17 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage seventeenth = new Stage("Suzuka", "Japan", income17);
            stages.AddStage(seventeenth);

            float[] income18 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage eigthteenth = new Stage("Lusail", "Quatar", income18);
            stages.AddStage(eigthteenth);

            float[] income19 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage ninthteenth = new Stage("Austin", "United States", income19);
            stages.AddStage(ninthteenth);

            float[] income20 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage twenty = new Stage("Mexico", "Mexico", income20);
            stages.AddStage(twenty);

            float[] income21 = { 8050, 9000, 15000, 10200, 8000, 9050, 8050, 9000, 15000, 12000, 8000, 9500, 7000, 7500, 12050, 10000, 6066.67f, 8000, 5701.43f, 6606.67f, 0, 0, 0, 0, 3033.33f, 4160.67f, 2050, 3330.33f, 2000, 2500, 1205, 2000, 1000, 1205, 5000, 10000, 2500, 5000, 1200.5f };
            Stage twenty1 = new Stage("Sao Paulo", "Brazil", income21);
            stages.AddStage(twenty1);

            float[] income22 = { 9000, 10000, 7500, 5000, 6500, 9000, 10000, 7500, 5000, 6050, 4500, 5500, 350, 450, 300, 350, 225, 300, 200, 0, 0, 0, 0, 150, 100, 125, 700, 1000, 500, 750, 3007.5f, 5000, 2500, 3007.5f, 1008.75f, 2005, 1002.5f, 1008.75f };
            Stage twenty2 = new Stage("Las Vegas", "United States", income22);
            stages.AddStage(twenty2);

            float[] income23 = { 5000, 8400, 9000, 5000, 8400, 9000, 7400, 6000, 10000, 4200, 7200, 7800, 6400, 8400, 3600, 6200, 6080, 0, 0, 0, 0, 6000, 4400, 4800, 2400, 4200, 3000, 2800, 1400, 2200, 1600, 1200, 600, 800, 400, 200 };
            Stage twenty3 = new Stage("Red Bull Ring", "Austria", income23);
            stages.AddStage(twenty3);

            stages.AddDistance(first, second, 200);
            stages.AddDistance(first, third, 1000);
            stages.AddDistance(first, fourth, 400);
            stages.AddDistance(first, fifth, 2000);
            stages.AddDistance(first, sixth, 600);
            stages.AddDistance(first, seventh, 800);
            stages.AddDistance(first, eigth, 900);
            stages.AddDistance(first, ninth, 2500);
            stages.AddDistance(first, tenth, 900);
            stages.AddDistance(first, eleven, 200);
            stages.AddDistance(first, twelwe, 1000);
            stages.AddDistance(first, thirteen, 400);
            stages.AddDistance(first, fourteenth, 2000);
            stages.AddDistance(first, fifteenth, 600);
            stages.AddDistance(first, sixteenth, 800);
            stages.AddDistance(first, seventeenth, 800);
            stages.AddDistance(first, eigthteenth, 900);
            stages.AddDistance(first, ninthteenth, 2500);
            stages.AddDistance(first, twenty, 900);
            stages.AddDistance(first, twenty1, 900);
            stages.AddDistance(first, twenty2, 2500);
            stages.AddDistance(first, twenty3, 900);

            //stages.AddDistance(first, second, 200);
            stages.AddDistance(second, third, 1000);
            stages.AddDistance(second, fourth, 400);
            stages.AddDistance(second, fifth, 2000);
            stages.AddDistance(second, sixth, 600);
            stages.AddDistance(second, seventh, 800);
            stages.AddDistance(second, eigth, 900);
            stages.AddDistance(second, ninth, 2500);
            stages.AddDistance(second, tenth, 900);
            stages.AddDistance(second, eleven, 200);
            stages.AddDistance(second, twelwe, 1000);
            stages.AddDistance(second, thirteen, 400);
            stages.AddDistance(second, fourteenth, 2000);
            stages.AddDistance(second, fifteenth, 600);
            stages.AddDistance(second, sixteenth, 800);
            stages.AddDistance(second, seventeenth, 800);
            stages.AddDistance(second, eigthteenth, 900);
            stages.AddDistance(second, ninthteenth, 2500);
            stages.AddDistance(second, twenty, 900);
            stages.AddDistance(second, twenty1, 900);
            stages.AddDistance(second, twenty2, 2500);
            stages.AddDistance(second, twenty3, 900);

            //stages.AddDistance(second, third, 900);
            stages.AddDistance(third, fourth, 500);
            stages.AddDistance(third, fifth, 2200);
            stages.AddDistance(third, sixth, 700);
            stages.AddDistance(third, seventh, 900);
            stages.AddDistance(third, eigth, 1000);
            stages.AddDistance(third, ninth, 2700);
            stages.AddDistance(third, tenth, 1000);
            stages.AddDistance(third, eleven, 200);
            stages.AddDistance(third, twelwe, 1000);
            stages.AddDistance(third, thirteen, 400);
            stages.AddDistance(third, fourteenth, 2000);
            stages.AddDistance(third, fifteenth, 600);
            stages.AddDistance(third, sixteenth, 800);
            stages.AddDistance(third, seventeenth, 800);
            stages.AddDistance(third, eigthteenth, 900);
            stages.AddDistance(third, ninthteenth, 2500);
            stages.AddDistance(third, twenty, 900);
            stages.AddDistance(third, twenty1, 900);
            stages.AddDistance(third, twenty2, 2500);
            stages.AddDistance(third, twenty3, 900);

            //stages.AddDistance(third, fourth, 2600);
            stages.AddDistance(fourth, fifth, 2000);
            stages.AddDistance(fourth, sixth, 900);
            stages.AddDistance(fourth, seventh, 500);
            stages.AddDistance(fourth, eigth, 6200);
            stages.AddDistance(fourth, ninth, 3000);
            stages.AddDistance(fourth, tenth, 740);
            stages.AddDistance(fourth, eleven, 200);
            stages.AddDistance(fourth, twelwe, 1000);
            stages.AddDistance(fourth, thirteen, 400);
            stages.AddDistance(fourth, fourteenth, 2000);
            stages.AddDistance(fourth, fifteenth, 600);
            stages.AddDistance(fourth, sixteenth, 800);
            stages.AddDistance(fourth, seventeenth, 800);
            stages.AddDistance(fourth, eigthteenth, 900);
            stages.AddDistance(fourth, ninthteenth, 2500);
            stages.AddDistance(fourth, twenty, 900);
            stages.AddDistance(fourth, twenty1, 900);
            stages.AddDistance(fourth, twenty2, 2500);
            stages.AddDistance(fourth, twenty3, 900);

            //stages.AddDistance(fourth, fifth, 1900);
            stages.AddDistance(fifth, sixth, 800);
            stages.AddDistance(fifth, seventh, 630);
            stages.AddDistance(fifth, eigth, 2350);
            stages.AddDistance(fifth, ninth, 860);
            stages.AddDistance(fifth, tenth, 1700);
            stages.AddDistance(fifth, eleven, 200);
            stages.AddDistance(fifth, twelwe, 1000);
            stages.AddDistance(fifth, thirteen, 400);
            stages.AddDistance(fifth, fourteenth, 2000);
            stages.AddDistance(fifth, fifteenth, 600);
            stages.AddDistance(fifth, sixteenth, 800);
            stages.AddDistance(fifth, seventeenth, 800);
            stages.AddDistance(fifth, eigthteenth, 900);
            stages.AddDistance(fifth, ninthteenth, 2500);
            stages.AddDistance(fifth, twenty, 900);
            stages.AddDistance(fifth, twenty1, 900);
            stages.AddDistance(fifth, twenty2, 2500);
            stages.AddDistance(fifth, twenty3, 900);

            //stages.AddDistance(fifth, sixth, 1000);
            stages.AddDistance(sixth, seventh, 3025);
            stages.AddDistance(sixth, eigth, 456);
            stages.AddDistance(sixth, ninth, 9500);
            stages.AddDistance(sixth, tenth, 600);
            stages.AddDistance(sixth, eleven, 200);
            stages.AddDistance(sixth, twelwe, 1000);
            stages.AddDistance(sixth, thirteen, 400);
            stages.AddDistance(sixth, fourteenth, 2000);
            stages.AddDistance(sixth, fifteenth, 600);
            stages.AddDistance(sixth, sixteenth, 800);
            stages.AddDistance(sixth, seventeenth, 800);
            stages.AddDistance(sixth, eigthteenth, 900);
            stages.AddDistance(sixth, ninthteenth, 2500);
            stages.AddDistance(sixth, twenty, 900);
            stages.AddDistance(sixth, twenty1, 900);
            stages.AddDistance(sixth, twenty2, 2500);
            stages.AddDistance(sixth, twenty3, 900);

            //stages.AddDistance(sixth, seventh, 430);
            stages.AddDistance(seventh, eigth, 785);
            stages.AddDistance(seventh, ninth, 2000);
            stages.AddDistance(seventh, tenth, 3000);
            stages.AddDistance(seventh, eleven, 200);
            stages.AddDistance(seventh, twelwe, 1000);
            stages.AddDistance(seventh, thirteen, 400);
            stages.AddDistance(seventh, fourteenth, 2000);
            stages.AddDistance(seventh, fifteenth, 600);
            stages.AddDistance(seventh, sixteenth, 800);
            stages.AddDistance(seventh, seventeenth, 800);
            stages.AddDistance(seventh, eigthteenth, 900);
            stages.AddDistance(seventh, ninthteenth, 2500);
            stages.AddDistance(seventh, twenty, 900);
            stages.AddDistance(seventh, twenty1, 900);
            stages.AddDistance(seventh, twenty2, 2500);
            stages.AddDistance(seventh, twenty3, 900);

            //stages.AddDistance(seventh, eigth, 750);
            stages.AddDistance(eigth, ninth, 1000);
            stages.AddDistance(eigth, tenth, 850);
            stages.AddDistance(eigth, eleven, 200);
            stages.AddDistance(eigth, twelwe, 1000);
            stages.AddDistance(eigth, thirteen, 400);
            stages.AddDistance(eigth, fourteenth, 2000);
            stages.AddDistance(eigth, fifteenth, 600);
            stages.AddDistance(eigth, sixteenth, 800);
            stages.AddDistance(eigth, seventeenth, 800);
            stages.AddDistance(eigth, eigthteenth, 900);
            stages.AddDistance(eigth, ninthteenth, 2500);
            stages.AddDistance(eigth, twenty, 900);
            stages.AddDistance(eigth, twenty1, 900);
            stages.AddDistance(eigth, twenty2, 2500);
            stages.AddDistance(eigth, twenty3, 900);

            //stages.AddDistance(eigth, ninth, 2400);
            stages.AddDistance(ninth, tenth, 1900);
            stages.AddDistance(ninth, eleven, 200);
            stages.AddDistance(ninth, twelwe, 1000);
            stages.AddDistance(ninth, thirteen, 400);
            stages.AddDistance(ninth, fourteenth, 2000);
            stages.AddDistance(ninth, fifteenth, 600);
            stages.AddDistance(ninth, sixteenth, 800);
            stages.AddDistance(ninth, seventeenth, 800);
            stages.AddDistance(ninth, eigthteenth, 900);
            stages.AddDistance(ninth, ninthteenth, 2500);
            stages.AddDistance(ninth, twenty, 900);
            stages.AddDistance(ninth, twenty1, 900);
            stages.AddDistance(ninth, twenty2, 2500);
            stages.AddDistance(ninth, twenty3, 900);

            //stages.AddDistance(ninth, tenth, 500);
            stages.AddDistance(tenth, eleven, 200);
            stages.AddDistance(tenth, twelwe, 1000);
            stages.AddDistance(tenth, thirteen, 400);
            stages.AddDistance(tenth, fourteenth, 2000);
            stages.AddDistance(tenth, fifteenth, 600);
            stages.AddDistance(tenth, sixteenth, 800);
            stages.AddDistance(tenth, seventeenth, 800);
            stages.AddDistance(tenth, eigthteenth, 900);
            stages.AddDistance(tenth, ninthteenth, 2500);
            stages.AddDistance(tenth, twenty, 900);
            stages.AddDistance(tenth, twenty1, 900);
            stages.AddDistance(tenth, twenty2, 2500);
            stages.AddDistance(tenth, twenty3, 900);

            //stages.AddDistance(first, eleven, 200);
            stages.AddDistance(eleven, twelwe, 1000);
            stages.AddDistance(eleven, thirteen, 400);
            stages.AddDistance(eleven, fourteenth, 2000);
            stages.AddDistance(eleven, fifteenth, 600);
            stages.AddDistance(eleven, sixteenth, 800);
            stages.AddDistance(eleven, seventeenth, 800);
            stages.AddDistance(eleven, eigthteenth, 900);
            stages.AddDistance(eleven, ninthteenth, 2500);
            stages.AddDistance(eleven, twenty, 900);
            stages.AddDistance(eleven, twenty1, 900);
            stages.AddDistance(eleven, twenty2, 2500);
            stages.AddDistance(eleven, twenty3, 900);

            //stages.AddDistance(first, twelwe, 1000);
            stages.AddDistance(twelwe, thirteen, 400);
            stages.AddDistance(twelwe, fourteenth, 2000);
            stages.AddDistance(twelwe, fifteenth, 600);
            stages.AddDistance(twelwe, sixteenth, 800);
            stages.AddDistance(twelwe, seventeenth, 800);
            stages.AddDistance(twelwe, eigthteenth, 900);
            stages.AddDistance(twelwe, ninthteenth, 2500);
            stages.AddDistance(twelwe, twenty, 900);
            stages.AddDistance(twelwe, twenty1, 900);
            stages.AddDistance(twelwe, twenty2, 2500);
            stages.AddDistance(twelwe, twenty3, 900);

            //stages.AddDistance(first, thirteen, 400);
            stages.AddDistance(thirteen, fourteenth, 2000);
            stages.AddDistance(thirteen, fifteenth, 600);
            stages.AddDistance(thirteen, sixteenth, 800);
            stages.AddDistance(thirteen, seventeenth, 800);
            stages.AddDistance(thirteen, eigthteenth, 900);
            stages.AddDistance(thirteen, ninthteenth, 2500);
            stages.AddDistance(thirteen, twenty, 900);
            stages.AddDistance(thirteen, twenty1, 900);
            stages.AddDistance(thirteen, twenty2, 2500);
            stages.AddDistance(thirteen, twenty3, 900);

            //stages.AddDistance(first, fourteenth, 2000);
            stages.AddDistance(fourteenth, fifteenth, 600);
            stages.AddDistance(fourteenth, sixteenth, 800);
            stages.AddDistance(fourteenth, seventeenth, 800);
            stages.AddDistance(fourteenth, eigthteenth, 900);
            stages.AddDistance(fourteenth, ninthteenth, 2500);
            stages.AddDistance(fourteenth, twenty, 900);
            stages.AddDistance(fourteenth, twenty1, 900);
            stages.AddDistance(fourteenth, twenty2, 2500);
            stages.AddDistance(fourteenth, twenty3, 900);

            //stages.AddDistance(fifteenth, fifteenth, 600);
            stages.AddDistance(fifteenth, sixteenth, 800);
            stages.AddDistance(fifteenth, seventeenth, 800);
            stages.AddDistance(fifteenth, eigthteenth, 900);
            stages.AddDistance(fifteenth, ninthteenth, 2500);
            stages.AddDistance(fifteenth, twenty, 900);
            stages.AddDistance(fifteenth, twenty1, 900);
            stages.AddDistance(fifteenth, twenty2, 2500);
            stages.AddDistance(fifteenth, twenty3, 900);

            stages.AddDistance(sixteenth, seventeenth, 800);
            stages.AddDistance(sixteenth, eigthteenth, 900);
            stages.AddDistance(sixteenth, ninthteenth, 2500);
            stages.AddDistance(sixteenth, twenty, 900);
            stages.AddDistance(sixteenth, twenty1, 900);
            stages.AddDistance(sixteenth, twenty2, 2500);
            stages.AddDistance(sixteenth, twenty3, 900);

            stages.AddDistance(seventeenth, eigthteenth, 900);
            stages.AddDistance(seventeenth, ninthteenth, 2500);
            stages.AddDistance(seventeenth, twenty, 900);
            stages.AddDistance(seventeenth, twenty1, 900);
            stages.AddDistance(seventeenth, twenty2, 2500);
            stages.AddDistance(seventeenth, twenty3, 900);

            stages.AddDistance(eigthteenth, ninthteenth, 2500);
            stages.AddDistance(eigthteenth, twenty, 900);
            stages.AddDistance(eigthteenth, twenty1, 900);
            stages.AddDistance(eigthteenth, twenty2, 2500);
            stages.AddDistance(eigthteenth, twenty3, 900);

            stages.AddDistance(ninthteenth, twenty, 900);
            stages.AddDistance(ninthteenth, twenty1, 900);
            stages.AddDistance(ninthteenth, twenty2, 2500);
            stages.AddDistance(ninthteenth, twenty3, 900);

            stages.AddDistance(twenty, twenty1, 900);
            stages.AddDistance(twenty, twenty2, 2500);
            stages.AddDistance(twenty, twenty3, 900);

            stages.AddDistance(twenty1, twenty2, 2500);
            stages.AddDistance(twenty1, twenty3, 900);

            stages.AddDistance(twenty2, twenty3, 900);

            return stages;
        }

    }
}