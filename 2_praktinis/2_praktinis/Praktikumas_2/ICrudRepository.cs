using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ICrudRepository<T>
{
    void LoadData();
    void InsertRecord(T record);
    void UpdateRecord(T record);
    void DeleteRecord(T record);
}