public class DynamicArray {

    private int[] arr;
    private int length;
    private int size;

    public DynamicArray(int capacity) {
        if(capacity > 0)
        {
            arr = new int[capacity];
            size = capacity;
            length = 0;
        }
    }

    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i] = n;
    }

    public void PushBack(int n) {
        if(length == size)
            Resize();
        arr[length] = n;
        length ++;
    }

    public int PopBack() {
        int res = arr[length-1];
        arr[length-1] = 0;
        length--;
        return res;
    }

    private void Resize() {
        int[] newArr = new int [size*2];
        for(int i = 0; i < length; i++)
        {
            newArr[i] = arr[i];
        }
        arr = newArr;
        size *= 2;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return size;
    }
}
