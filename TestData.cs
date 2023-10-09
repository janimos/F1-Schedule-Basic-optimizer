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

            float[] income1 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f };
            Stage first = new Stage("Sakhir", "Bahrein", income1);
            stages.AddStage(first);

            float[] income2 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage second = new Stage("Jeddah", "Saudi Arabia", income2);
            stages.AddStage(second);

            float[] income3 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
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

            float[] income1 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f };
            Stage first = new Stage("Sakhir", "Bahrein", income1);
            stages.AddStage(first);

            float[] income2 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage second = new Stage("Jeddah", "Saudi Arabia", income2);
            stages.AddStage(second);

            float[] income3 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage third = new Stage("Melbourne", "Australia", income3);
            stages.AddStage(third);

            float[] income4 = { 750, 1000, 571.43f, 800, 125, 1500, 12.5f, 1250, 800, 100, 666.67f, 900, 700, 250, 1200, 900, 333.33f, 416.67f, 850, 500, 200, 666.67f, 800, 125, 1500, 571.43f, 333.33f, 50, 250, 416.67f, 950, 500, 100, 1200, 800, 571.43f, 25 };
            Stage fourth = new Stage("Baku", "Azerbaijan", income4);
            stages.AddStage(fourth);

            float[] income5 = { 420, 260, 840, 680, 260, 840, 600, 240, 900, 440, 840, 780, 120, 840, 220, 560, 600, 600, 500, 1000, 480, 420, 720, 360, 540, 640, 600, 280, 300, 160, 80, 20, 40, 840, 740 };
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

            float[] income1 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f };
            Stage first = new Stage("Sakhir", "Bahrein", income1);
            stages.AddStage(first);

            float[] income2 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage second = new Stage("Jeddah", "Saudi Arabia", income2);
            stages.AddStage(second);

            float[] income3 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage third = new Stage("Melbourne", "Australia", income3);
            stages.AddStage(third);

            float[] income4 = { 750, 1000, 571.43f, 800, 125, 1500, 12.5f, 1250, 800, 100, 666.67f, 900, 700, 250, 1200, 900, 333.33f, 416.67f, 850, 500, 200, 666.67f, 800, 125, 1500, 571.43f, 333.33f, 50, 250, 416.67f, 950, 500, 100, 1200, 800, 571.43f, 25 };
            Stage fourth = new Stage("Baku", "Azerbaijan", income4);
            stages.AddStage(fourth);

            float[] income5 = { 420, 260, 840, 680, 260, 840, 600, 240, 900, 440, 840, 780, 120, 840, 220, 560, 600, 600, 500, 1000, 480, 420, 720, 360, 540, 640, 600, 280, 300, 160, 80, 20, 40, 840, 740 };
            Stage fifth = new Stage("Miami", "United States", income5);
            stages.AddStage(fifth);

            float[] income6 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f };
            Stage sixth = new Stage("Imola", "Italy", income6);
            stages.AddStage(sixth);

            float[] income7 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage seventh = new Stage("Monaco", "Monaco", income7);
            stages.AddStage(seventh);

            float[] income8 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage eigth = new Stage("Barcelona", "Spain", income8);
            stages.AddStage(eigth);

            float[] income9 = { 750, 1000, 571.43f, 800, 125, 1500, 12.5f, 1250, 800, 100, 666.67f, 900, 700, 250, 1200, 900, 333.33f, 416.67f, 850, 500, 200, 666.67f, 800, 125, 1500, 571.43f, 333.33f, 50, 250, 416.67f, 950, 500, 100, 1200, 800, 571.43f, 25 };
            Stage ninth = new Stage("Montreal", "Canada", income9);
            stages.AddStage(ninth);

            float[] income10 = { 420, 260, 840, 680, 260, 840, 600, 240, 900, 440, 840, 780, 120, 840, 220, 560, 600, 600, 500, 1000, 480, 420, 720, 360, 540, 640, 600, 280, 300, 160, 80, 20, 40, 840, 740 };
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

            float[] income1 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f };
            Stage first = new Stage("Sakhir", "Bahrein", income1);
            stages.AddStage(first);

            float[] income2 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage second = new Stage("Jeddah", "Saudi Arabia", income2);
            stages.AddStage(second);

            float[] income3 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage third = new Stage("Melbourne", "Australia", income3);
            stages.AddStage(third);

            float[] income4 = { 750, 1000, 571.43f, 800, 125, 1500, 12.5f, 1250, 800, 100, 666.67f, 900, 700, 250, 1200, 900, 333.33f, 416.67f, 850, 500, 200, 666.67f, 800, 125, 1500, 571.43f, 333.33f, 50, 250, 416.67f, 950, 500, 100, 1200, 800, 571.43f, 25 };
            Stage fourth = new Stage("Baku", "Azerbaijan", income4);
            stages.AddStage(fourth);

            float[] income5 = { 420, 260, 840, 680, 260, 840, 600, 240, 900, 440, 840, 780, 120, 840, 220, 560, 600, 600, 500, 1000, 480, 420, 720, 360, 540, 640, 600, 280, 300, 160, 80, 20, 40, 840, 740 };
            Stage fifth = new Stage("Miami", "United States", income5);
            stages.AddStage(fifth);

            float[] income6 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f };
            Stage sixth = new Stage("Imola", "Italy", income6);
            stages.AddStage(sixth);

            float[] income7 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage seventh = new Stage("Monaco", "Monaco", income7);
            stages.AddStage(seventh);

            float[] income8 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage eigth = new Stage("Barcelona", "Spain", income8);
            stages.AddStage(eigth);

            float[] income9 = { 750, 1000, 571.43f, 800, 125, 1500, 12.5f, 1250, 800, 100, 666.67f, 900, 700, 250, 1200, 900, 333.33f, 416.67f, 850, 500, 200, 666.67f, 800, 125, 1500, 571.43f, 333.33f, 50, 250, 416.67f, 950, 500, 100, 1200, 800, 571.43f, 25 };
            Stage ninth = new Stage("Montreal", "Canada", income9);
            stages.AddStage(ninth);

            float[] income10 = { 420, 260, 840, 680, 260, 840, 600, 240, 900, 440, 840, 780, 120, 840, 220, 560, 600, 600, 500, 1000, 480, 420, 720, 360, 540, 640, 600, 280, 300, 160, 80, 20, 40, 840, 740 };
            Stage tenth = new Stage("Red Bull Ring", "Austria", income10);
            stages.AddStage(tenth);

            float[] income11 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f };
            Stage eleven = new Stage("Silverstone", "United Kingdom", income11);
            stages.AddStage(eleven);

            float[] income12 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage twelwe = new Stage("Budapest", "Hugary", income12);
            stages.AddStage(twelwe);

            float[] income13 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage thirteen = new Stage("Spa", "Belgium", income13);
            stages.AddStage(thirteen);

            float[] income14 = { 750, 1000, 571.43f, 800, 125, 1500, 12.5f, 1250, 800, 100, 666.67f, 900, 700, 250, 1200, 900, 333.33f, 416.67f, 850, 500, 200, 666.67f, 800, 125, 1500, 571.43f, 333.33f, 50, 250, 416.67f, 950, 500, 100, 1200, 800, 571.43f, 25 };
            Stage fourteenth = new Stage("Zandvoort", "Netherlands", income14);
            stages.AddStage(fourteenth);

            float[] income15 = { 420, 260, 840, 680, 260, 840, 600, 240, 900, 440, 840, 780, 120, 840, 220, 560, 600, 600, 500, 1000, 480, 420, 720, 360, 540, 640, 600, 280, 300, 160, 80, 20, 40, 840, 740 };
            Stage fifteenth = new Stage("Monza", "Italy", income15);
            stages.AddStage(fifteenth);

            float[] income16 = { 900, 1000, 750, 500, 650, 900, 1000, 750, 500, 650, 450, 550, 350, 450, 300, 350, 225, 300, 200, 225, 150, 200, 125, 150, 100, 125, 75, 100, 50, 75, 37.5f, 50, 25, 37.5f, 18.75f, 25, 12.5f, 18.75f };
            Stage sixteenth = new Stage("Singapore", "Singapore", income16);
            stages.AddStage(sixteenth);

            float[] income17 = { 850, 900, 1500, 1200, 800, 950, 850, 900, 1500, 1200, 800, 950, 700, 750, 1250, 1000, 666.67f, 800, 571.43f, 666.67f, 500, 571.43f, 416.67f, 500, 333.33f, 416.67f, 250, 333.33f, 200, 250, 125, 200, 100, 125, 50, 100, 25, 50, 12.5f };
            Stage seventeenth = new Stage("Suzuka", "Japan", income17);
            stages.AddStage(seventeenth);

            float[] income18 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage eigthteenth = new Stage("Lusail", "Quatar", income18);
            stages.AddStage(eigthteenth);

            float[] income19 = { 750, 1000, 571.43f, 800, 125, 1500, 12.5f, 1250, 800, 100, 666.67f, 900, 700, 250, 1200, 900, 333.33f, 416.67f, 850, 500, 200, 666.67f, 800, 125, 1500, 571.43f, 333.33f, 50, 250, 416.67f, 950, 500, 100, 1200, 800, 571.43f, 25 };
            Stage ninthteenth = new Stage("Austin", "United States", income19);
            stages.AddStage(ninthteenth);

            float[] income20 = { 420, 260, 840, 680, 260, 840, 600, 240, 900, 440, 840, 780, 120, 840, 220, 560, 600, 600, 500, 1000, 480, 420, 720, 360, 540, 640, 600, 280, 300, 160, 80, 20, 40, 840, 740 };
            Stage twenty = new Stage("Mexico", "Mexico", income20);
            stages.AddStage(twenty);

            float[] income21 = { 500, 840, 900, 500, 840, 900, 740, 600, 1000, 420, 720, 780, 640, 840, 360, 620, 680, 560, 600, 260, 540, 600, 440, 480, 240, 420, 300, 280, 140, 220, 160, 120, 60, 80, 40, 20 };
            Stage twenty1 = new Stage("Sao Paulo", "Brazil", income21);
            stages.AddStage(twenty1);

            float[] income22 = { 750, 1000, 571.43f, 800, 125, 1500, 12.5f, 1250, 800, 100, 666.67f, 900, 700, 250, 1200, 900, 333.33f, 416.67f, 850, 500, 200, 666.67f, 800, 125, 1500, 571.43f, 333.33f, 50, 250, 416.67f, 950, 500, 100, 1200, 800, 571.43f, 25 };
            Stage twenty2 = new Stage("Las Vegas", "United States", income22);
            stages.AddStage(twenty2);

            float[] income23 = { 420, 260, 840, 680, 260, 840, 600, 240, 900, 440, 840, 780, 120, 840, 220, 560, 600, 600, 500, 1000, 480, 420, 720, 360, 540, 640, 600, 280, 300, 160, 80, 20, 40, 840, 740 };
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