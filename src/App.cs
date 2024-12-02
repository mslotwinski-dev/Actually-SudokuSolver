namespace Actually.Core;

using System;
using System.Linq;
using System.Collections.Generic;
  
class App {
  public void Init() {
    uint[,] Start = {
      { 0, 0, 0, /**/ 0, 4, 0, /**/ 0, 0, 0 },
      { 0, 0, 0, /**/ 0, 0, 0, /**/ 8, 0, 0 },
      { 0, 1, 9, /**/ 0, 0, 0, /**/ 0, 3, 0 },
      ////////////////////////////////////////
      { 0, 3, 8, /**/ 0, 0, 4, /**/ 9, 0, 0 },
      { 0, 0, 0, /**/ 0, 0, 0, /**/ 2, 7, 1 },
      { 6, 0, 0, /**/ 1, 0, 0, /**/ 0, 0, 8 },
      ////////////////////////////////////////
      { 0, 6, 2, /**/ 0, 0, 5, /**/ 7, 0, 4 },
      { 0, 5, 0, /**/ 2, 0, 8, /**/ 0, 0, 0 },
      { 8, 0, 0, /**/ 0, 0, 0, /**/ 0, 0, 6 },

    };

    Sudoku sudoku = new Sudoku(Start);

    sudoku.Solve();

    sudoku.Print();



  }
}