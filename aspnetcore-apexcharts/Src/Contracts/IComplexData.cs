namespace aspnetcore_apexcharts.Contracts
{
    public interface IComplexData<out T>
    {
        public T AddData(string name, int[] data);
    }
}