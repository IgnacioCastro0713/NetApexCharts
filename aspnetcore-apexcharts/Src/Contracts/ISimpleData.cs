using aspnetcore_apexcharts.Charts;

namespace aspnetcore_apexcharts.Contracts
{
    public interface ISimpleData <out T>
    {
        public T AddData(int[] data);
    }
}