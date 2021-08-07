using UnityEngine;
using UnityEngine.UI;

public class CursorVisitor : Visitor
{
    private Ray ray;
    Animator animator;

    public GameObject comment;

    public Camera mainCamera;

    public override void Visit(ItemAcceptor acceptor)
    {
        acceptor.Accept(this);
        animator.SetTrigger("Pickup");
    }

    public override void Visit(ActorAcceptor acceptor)
    {
        acceptor.Accept(this);
        //Debug.Log("会話モードへ移行する処理");
        comment.SetActive(true);
    }

    void Start()
    {
        ray = new Ray();

        animator = GetComponent<Animator>();

        comment = GameObject.Find("Comment");
        comment.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject game = hit.collider.gameObject;

                ItemAcceptor item = game.GetComponent<ItemAcceptor>();
                if (item != null) Visit(item);

                ActorAcceptor actor = game.GetComponent<ActorAcceptor>();
                if (actor != null) Visit(actor);
            }
        }
    }
}

