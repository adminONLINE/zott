public class CANAVAR : MonoBehaviour

{
    public Vector3 yol;
    public float süre;
    private int sayac = 2;
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.name.Equals("Player"))
        {
            sayac = 0;
            transform.position += yol;
        }
    }
    void Update()
    {
        if (sayac == 0)
       {
            if (süre > 0)
         {
            süre -= Time.deltaTime;
         }
        else if (süre < 0)
            {
            
                transform.position -= yol;
                süre = 5;
                sayac = 1;

            }
       }

    }
}
