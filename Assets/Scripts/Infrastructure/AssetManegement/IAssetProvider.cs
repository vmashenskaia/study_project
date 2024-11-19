using Infrastructure.Services;
using UnityEngine;

namespace Infrastructure.AssetManegement
{
    public interface IAssetProvider: IService
    {
        GameObject Instantiate(string path, Vector3 at);
        GameObject Instantiate(string path);
    }
}