using UnityEngine;

public class HidingPlace : MonoBehaviour
{
    public BoxCollider box;
    public GameObject Player;
    public GameObject posterGameObject;
    private HideOpcionText poster;
    private Player player; // Variable para almacenar al jugador cuando entre en el trigger.

    void Start()
    {
        if (box == null)
        {
            box = GetComponent<BoxCollider>();
        }
        box.isTrigger = true;
        box.size = new Vector3(3.5f, 3.5f, 3.5f);

        // Obtener el componente HideOpcionText del GameObject posterGameObject
        if (posterGameObject != null)
        {
            poster = posterGameObject.GetComponent<HideOpcionText>();
        }
        else
        {
            Debug.LogError("El GameObject 'posterGameObject' no est� asignado.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        player = other.GetComponentInParent<Player>();
        Debug.Log(player);

        if (player != null)
        {
            if (poster != null)
            {
                poster.Show_Option();
            }
            Debug.Log("Me com� un mueble.");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (player != null && player.IsHiding())
        {
            poster.Hide_Option();
        }
        else if (player != null && !player.IsHiding())
        {
            poster.Show_Option();
        }
    }

    void OnTriggerExit(Collider other)
    {
        Player exitingPlayer = other.GetComponentInParent<Player>();

        // Verifica que el jugador que sale sea el mismo que el que entr�
        if (exitingPlayer != null && exitingPlayer == player)
        {
            Debug.Log("Me desescond�.");
            player = null; // El jugador ya no est� en el �rea.
            if (poster != null)
            {
                poster.Hide_Option();
            }
        }
    }

    void Update()
    {
        // Solo hacer algo si el jugador est� en el �rea del trigger
        if (player != null)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                player.hiding = !player.IsHiding(); // Alternar el estado de esconderse.

                if (player.IsHiding())
                {
                    Debug.Log("El jugador se est� escondiendo.");
                    player.Immobilize();
                    poster.Hide_Option();
                }
                else
                {
                    Debug.Log("El jugador ha salido del escondite.");
                    player.Mobilize();
                    poster.Show_Option();
                }
            }
        }
    }
}
