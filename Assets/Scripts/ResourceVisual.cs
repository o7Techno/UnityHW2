using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ResourceVisual : MonoBehaviour
{
    [SerializeField]
    GameResource.Resource resourceType;
    GameResource resource;
    [SerializeField]
    GameManager gameManager;
    TextMeshProUGUI Text;
    ObservableInt amount;



    private void Awake()
    {
        if (!TryGetComponent<TextMeshProUGUI>(out Text))
        {
            Debug.LogError("Text was not found");
        }
        resource = gameManager.resourceBank.GetGameResource(resourceType);
        amount = gameManager.resourceBank.GetResource(resource);
        ChangeAmount(amount.Value);
    }

    private void OnEnable()
    {
        amount.OnValueChanged += ChangeAmount;
    }

    private void OnDisable()
    {
        amount.OnValueChanged -= ChangeAmount;
    }

    private void ChangeAmount(int val)
    {
        Text.text = val.ToString();
    }
}
