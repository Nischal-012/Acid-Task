
public abstract class UIPanelData<T>
{

	protected T data;
	public T Data { get; }


	public abstract void CreateWithData(T data);

}
