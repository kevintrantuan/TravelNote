namespace TravelNote.Common1
{
	using System.Threading.Tasks;

	public interface ICameraProvider
	{
		Task<CameraResult> TakePictureAsync();
	}
}



