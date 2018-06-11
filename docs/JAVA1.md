 ```java
    public static boolean arraySumsToK(int[] list, int k)
    {
        for(int i=0; i < list.length - 1; i++) {
            for(int j=i + 1; j < list.length; j++) {
                if(list[i] + list[j] == k) {
                    System.out.printf("i=%s j=%s\n", i, j);
                    return true;
                }
            }
        }
        return false;
    }
 ```
