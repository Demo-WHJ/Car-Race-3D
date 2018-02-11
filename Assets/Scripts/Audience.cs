using UnityEngine;
using System.Collections;

public class Audience : MonoBehaviour
{

private string[] names = { "idle", "applause", "applause2", "celebration", "celebration2", "celebration3" };

// Use this for initialization
void Start()
{
Animation[] AudienceMembers = gameObject.GetComponentsInChildren<Animation>();
foreach (Animation anim in AudienceMembers)
{
StartCoroutine(setAnimation(anim));
}
}

IEnumerator setAnimation(Animation anim)
{
string thisAnimation = names[Random.Range(0, 5)];
float timePeriod = Random.Range(0f, 4f);

anim.wrapMode = WrapMode.Loop;
anim.GetComponent<Animation>().CrossFade(thisAnimation);
anim[thisAnimation].time = timePeriod;

yield return new WaitForSeconds(timePeriod);
StartCoroutine(setAnimation(anim));
yield return null;
}
}