using System;

namespace MyLib {
  public class Calculator {

    /// <summary>
    /// 素数かどうかを判定する（試し割り法, 計算量 O(N)）．
    /// </summary>
    public bool IsPrime(long n) {
      if (n < 2) return false;

      for (long i = 2; i < n; i++) {
        if (n % i == 0) return false;
      }
      return true;
    }

    /// <summary>
    /// 素数かどうかを判定する（平方根までで打ち切る最適化版, 計算量 O(√N)）．
    /// </summary>
    public bool IsPrimeOptimized(long n) {
      if (n < 2) return false;

      for (long i = 2; i * i <= n; i++) {
        if (n % i == 0) return false;
      }
      return true;
    }
  }
}