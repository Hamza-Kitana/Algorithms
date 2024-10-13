using Algo22.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Algo22.Controllers
{
    public class SortAlgorithmController : Controller
    {


        private static Details _algorithm = new();
        private static List<Details> Dls = new();
        public void fulllist()
        {
            
            if (_algorithm.sort.Insertion)
            {

                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                int count;
                do
                {
                    long startMemory = GC.GetTotalMemory(true);
                    node.algorithm.Insertion(_algorithm.Array , out count);
                    long endMemory = GC.GetTotalMemory(true);

                    node.MemoryUsed = endMemory - startMemory;
                } while (node.MemoryUsed <= 0);
                
                int count3;

                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Insertion(_algorithm.Array, out count3);
                stopwatch.Stop();
                node.N = count3;
                
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Insertion";
                Dls.Add(node);
            }
            if (_algorithm.sort.Heap)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                int count;
                do
                {
                    long startMemory = GC.GetTotalMemory(true);
                    node.algorithm.Heap(_algorithm.Array, out count);
                    long endMemory = GC.GetTotalMemory(true);

                    node.MemoryUsed = endMemory - startMemory;
                } while (node.MemoryUsed <= 0);

                int count3;

                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Heap(_algorithm.Array, out count3);
                stopwatch.Stop();
                node.N = count3;

                node.Time = stopwatch.Elapsed.TotalMilliseconds;



                node.sorted = "Heap";
                Dls.Add(node);
            }
            if (_algorithm.sort.Counting)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                int count;
                do
                {
                    long startMemory = GC.GetTotalMemory(true);
                    node.algorithm.Counting(_algorithm.Array, out count);
                    long endMemory = GC.GetTotalMemory(true);

                    node.MemoryUsed = endMemory - startMemory;
                } while (node.MemoryUsed <= 0);

                int count3;

                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Counting(_algorithm.Array, out count3);
                stopwatch.Stop();
                node.N = count3;

                node.Time = stopwatch.Elapsed.TotalMilliseconds;



                node.sorted = "Counting";
                Dls.Add(node);
            }
            if (_algorithm.sort.Bubble)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Bubble(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Bubble";
                Dls.Add(node);
            }
            if (_algorithm.sort.Bucket)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Bucket(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Bucket";
                Dls.Add(node);
            }
            if (_algorithm.sort.Cocktail)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Cocktail(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Cocktail";
                Dls.Add(node);
            }
            if (_algorithm.sort.Comb)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Comb(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Comb";
                Dls.Add(node);
            }
            if (_algorithm.sort.Cycle)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Cycle(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Cycle";
                Dls.Add(node);
            }
            if (_algorithm.sort.Bitonic)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Bitonic(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Bitonic";
                Dls.Add(node);
            }
            if (_algorithm.sort.Bitonic)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Bitonic(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Bitonic";
                Dls.Add(node);
            }
            if (_algorithm.sort.Merge)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Merge(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Merge";
                Dls.Add(node);
            }
            if (_algorithm.sort.Pancake)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Pancake(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Pancake";
                Dls.Add(node);
            }
            if (_algorithm.sort.Pigeonhole)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Pigeonhole(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Pigeonhole";
                Dls.Add(node);
            }
            if (_algorithm.sort.Quick)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Quick(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Quick";
                Dls.Add(node);
            }
            if (_algorithm.sort.Radix)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Radix(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Radix";
                Dls.Add(node);
            }
            if (_algorithm.sort.Selection)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Selection(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Selection";
                Dls.Add(node);
            }
            if (_algorithm.sort.Shell)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Shell(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Shell";
                Dls.Add(node);
            }
            if (_algorithm.sort.Sleep)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Sleep(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Sleep";
                Dls.Add(node);
            }
            if (_algorithm.sort.Stooge)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Stooge(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Stooge";
                Dls.Add(node);
            }
            if (_algorithm.sort.Tag)
            {
                Details node = new Details();
                node.Array = _algorithm.Array;
                node.Array2 = _algorithm.Array2;
                node.sort = _algorithm.sort;

                long startMemory = GC.GetTotalMemory(true);
                Stopwatch stopwatch = Stopwatch.StartNew();
                node.algorithm.Tag(_algorithm.Array);
                stopwatch.Stop();
                long endMemory = GC.GetTotalMemory(true);
                node.MemoryUsed = endMemory - startMemory;
                node.Time = stopwatch.Elapsed.TotalMilliseconds;


                node.sorted = "Tag";
                Dls.Add(node);
            }

        }
        public IActionResult ViewAll()
        {
            fulllist();

            return View(Dls);
        }
        public IActionResult RandomOrNot()
        {

            return View();
        }
        public IActionResult Random()
        {
            int seed = (int)DateTime.Now.Ticks;
            Random random = new Random(seed);

            
            for (int i = 0; i < _algorithm.Array.Length; i++)
            {
                int randoms = random.Next(0, 200);
                _algorithm.Array[i] = randoms;
                _algorithm.Array2[i] = randoms;
            }

            return RedirectToAction(nameof(TryIt));
        }


        [HttpGet]
        public IActionResult NotRandom()
        {
            return View(_algorithm);
        }
        [HttpPost]
        public IActionResult NotRandom(Details algorithm)
        {


            for (int i = 0; i < algorithm.Array.Length; i++)
            {
                _algorithm.Array2[i] = algorithm.Array[i];
                _algorithm.Array[i] = algorithm.Array[i];
            }

            return RedirectToAction(nameof(TryIt));
        }
        [HttpGet]
        public IActionResult TryIt()
        {
            Dls = new();
            return View(_algorithm);
        }
        [HttpPost]
        public IActionResult TryIt(Details hh)
        {
            _algorithm.sort= hh.sort;
            return RedirectToAction(nameof(ViewAll));
        }
        public IActionResult SizeArray()
        {
            return View(_algorithm);
        }
        [HttpPost]
        public IActionResult SizeArray(Details x)
        {
            _algorithm.SizeArray = x.SizeArray;
            if (_algorithm.SizeArray < 100)
            {
                _algorithm.box[0] = 1;
                _algorithm.box[1] = 1;
                _algorithm.box[2] = 1;
                _algorithm.box[6] = 1;
                _algorithm.box[11] = 1;
                _algorithm.box[14] = 1;
                _algorithm.box[15] = 1;
                _algorithm.box[18] = 1;
                _algorithm.box[19] = 1;
            }
            if (_algorithm.SizeArray >= 100)
            {
                _algorithm.box[3] = 1;
                _algorithm.box[4] = 1;
                _algorithm.box[5] = 1;
                _algorithm.box[7] = 1;
                _algorithm.box [8] = 1;
                _algorithm.box[9] = 1;
                _algorithm.box[10] = 1;
                _algorithm.box[12] = 1;
                _algorithm.box[13] = 1;
                _algorithm.box[16] = 1;
                _algorithm.box[17] = 1;

            }
            _algorithm.Array = new int[x.SizeArray];
            _algorithm.Array2 = new int[x.SizeArray];
            return RedirectToAction("RandomOrNot");
        }
        public IActionResult Insertion()
        {
            return View();
        }
        public IActionResult Heap()
        {
            
            return View();
        }
        public IActionResult Counting()
        {
          
            return View();
        }



        public IActionResult Radix()
        {
          
            return View();

        }

        public IActionResult Tag()
        {
            
            return View();
        }

        public IActionResult Cocktail()
        {
           
            return View();
        }
        public IActionResult Comb()
        {
           
            return View();
        }
        public IActionResult Pancake()
        {
           
            return View();
        }
        public IActionResult Cycle()
        {
            
            return View();
        }
        public IActionResult Bucket()
        {
           
            return View();
        }
        public IActionResult Selection()
        {
           
            return View();
        }
        public IActionResult Bubble()
        {
           
            return View();
        }

        public IActionResult Merge()
        {
           
            return View();
        }
        public IActionResult Stooge()
        {
           
            return View();
        }

        public IActionResult Gnome()
        {
            
            return View();
        }
        public IActionResult Bitonic()
        {
           
            return View();
        }
        public IActionResult Pigeonhole()
        {
           
            return View();
        }
        public IActionResult Quick()
        {
            
            return View();
        }
        public IActionResult Shell()
        {
           
            return View();
        }


        public IActionResult Sleep()
        {
           
            return View();
        }
    }
}
