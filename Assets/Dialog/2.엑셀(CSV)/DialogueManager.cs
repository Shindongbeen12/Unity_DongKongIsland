using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText;       // NPC의 이름을 표시할 UI
    public TMP_Text dialogueText;   // 대사를 표시할 UI
    public GameObject dialogueBox;  // 대화 창 UI (패널)

    private Queue<string> names;     // 대화에서 등장하는 이름 목록
    private Queue<string> dialogues; // 대사 목록

    public string nullname;

    void Start()
    {
        names = new Queue<string>();
        dialogues = new Queue<string>();
        LoadDialogueFromCSV("test.csv"); // CSV 파일에서 대화 내용 로드
    }

    // CSV 파일에서 대화와 이름을 큐에 저장
    void LoadDialogueFromCSV(string filename)
    {
        string path = Path.Combine(Application.streamingAssetsPath, filename);

        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            bool firstLine = true;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (firstLine) // 첫 번째 줄은 헤더이므로 건너뜀
                {
                    firstLine = false;
                    continue;
                }

                string[] entries = line.Split(',');
                if (entries.Length == 3)
                {
                    string npcName = entries[1].Trim();
                    string dialogue = entries[2].Trim();

                    names.Enqueue(npcName);
                    dialogues.Enqueue(dialogue);
                }
            }
            reader.Close();

            DisplayNextSentence(); // 첫 번째 대사 표시
        }
        else
        {
            Debug.LogError("CSV 파일을 찾을 수 없습니다.");
        }
    }

    // 다음 대사 표시
    public void DisplayNextSentence()
    {
        if (dialogues.Count == 0)
        {
            EndDialogue();
            return;
        }

        // 이름과 대사를 큐에서 꺼냄
        string name = names.Dequeue();
        string sentence = dialogues.Dequeue();

        // name이 null 또는 빈 문자열인지 확인
        if (string.IsNullOrEmpty(name))
        {
            Debug.LogWarning("이름 값이 null이거나 비어 있습니다!");
            nameText.text = nullname;  // 이전 이름 사용
        }
        else
        {
            nameText.text = name;  // 정상적인 이름 값을 설정
            nullname = name;
        }

        dialogueText.text = sentence;  // 대사를 설정
        dialogueBox.SetActive(true);    // 대화 상자 표시
    }

    // 대화 종료 처리
    void EndDialogue()
    {
        dialogueBox.SetActive(false);
        Debug.Log("대화 종료");
    }
}

//public class DialogueManager : MonoBehaviour
//{
//    public TMP_Text dialogueText;  // ????댁슜???쒖떆???띿뒪??
//    public TMP_Text speakerText;   // ?붿옄瑜??쒖떆???띿뒪??
//    public GameObject nextButton;  // "?ㅼ쓬" 踰꾪듉

//    private Dictionary<int, Dialogue> dialogueDictionary = new Dictionary<int, Dialogue>();
//    private int currentDialogueID;
//    private Coroutine typingCoroutine;
//    private bool isTyping = false;

//    void Start()
//    {
//        LoadCSV("Assets/Story/dialogue.csv");
//        StartDialogue(1);  // ID 1踰???붾????쒖옉
//    }

//    // CSV ?뚯씪???쎌뼱????뺤뀛?덈━????ν븯??硫붿꽌??
//    void LoadCSV(string path)
//    {
//        using (StreamReader sr = new StreamReader(path))
//        {
//            string line;
//            bool isFirstLine = true;

//            while ((line = sr.ReadLine()) != null)
//            {
//                if (isFirstLine)
//                {
//                    isFirstLine = false;  // 泥?踰덉㎏ 以??ㅻ뜑)??嫄대꼫?곷땲??
//                    continue;
//                }

//                string[] values = line.Split(',');

//                // 諛곗뿴 湲몄씠媛 3蹂대떎 ?묒쑝硫?臾댁떆 (ID, Speaker, Dialogue??3媛쒓? ?덉뼱????
//                if (values.Length < 3 || string.IsNullOrEmpty(values[0]))
//                    continue;  // ID媛 ?녿뒗 寃쎌슦 臾댁떆

//                // ID, Speaker, Dialogue 泥섎━
//                int id = int.Parse(values[0]);
//                string speaker = values[1];
//                string dialogueText = values[2];

//                Dialogue dialogue = new Dialogue(id, speaker, dialogueText);
//                dialogueDictionary.Add(id, dialogue);
//            }
//        }
//    }

//    // ??붾? ?쒖옉?섎뒗 硫붿꽌??
//    void StartDialogue(int dialogueID)
//    {
//        if (dialogueDictionary.ContainsKey(dialogueID))
//        {
//            if (typingCoroutine != null)
//            {
//                StopCoroutine(typingCoroutine);  // ?댁쟾 肄붾（?댁씠 ?ㅽ뻾 以묒씠硫?以묒?
//            }
//            nextButton.SetActive(false);  // ??댄븨 以묒뿉??踰꾪듉 鍮꾪솢?깊솕
//            DisplayDialogue(dialogueID);
//        }
//        else
//        {
//            Debug.LogWarning("???ID瑜?李얠쓣 ???놁뒿?덈떎: " + dialogueID);
//        }
//    }

//    // ?꾩옱 ??붾? UI???쒖떆?섎뒗 硫붿꽌??
//    void DisplayDialogue(int dialogueID)
//    {
//        Dialogue currentDialogue = dialogueDictionary[dialogueID];
//        speakerText.text = currentDialogue.Speaker;

//        // ?띿뒪?멸? ?쒖감?곸쑝濡??쒖떆?섎룄濡?肄붾（???ㅽ뻾
//        typingCoroutine = StartCoroutine(TypeDialogue(currentDialogue.DialogueText));

//        currentDialogueID = dialogueID;
//    }

//    // ?띿뒪?몃? ?쒖감?곸쑝濡?異쒕젰?섎뒗 肄붾（??
//    IEnumerator TypeDialogue(string dialogue)
//    {
//        isTyping = true;  // ??댄븨 以??곹깭濡??ㅼ젙
//        dialogueText.text = "";  // 湲곗〈 ?띿뒪??珥덇린??

//        foreach (char letter in dialogue.ToCharArray())
//        {
//            dialogueText.text += letter;  // ??湲?먯뵫 異붽?
//            yield return new WaitForSeconds(0.05f);  // ?띿뒪??異쒕젰 ?띾룄
//        }

//        isTyping = false;  // ??댄븨 ?꾨즺 ?곹깭濡??ㅼ젙
//        nextButton.SetActive(true);  // ??댄븨???꾨즺?섎㈃ 踰꾪듉 ?쒖꽦??
//    }

//    // "?ㅼ쓬" 踰꾪듉???뚮??????몄텧?섎뒗 硫붿꽌??
//    public void OnNextButtonClicked()
//    {
//        if (isTyping) return;  // ??댄븨 以묒뿉???ㅼ쓬?쇰줈 ?섏뼱媛吏 ?딆쓬

//        if (dialogueDictionary.ContainsKey(currentDialogueID + 1))  // ?ㅼ쓬 ??붽? ?덉쑝硫?
//        {
//            StartDialogue(currentDialogueID + 1);
//        }
//        else
//        {
//            Debug.Log("???醫낅즺");
//            nextButton.SetActive(false);  // ??붽? ?앸궗????踰꾪듉??鍮꾪솢?깊솕
//        }
//    }
//}

//// ????곗씠?곕? ??ν븯???대옒??
//public class Dialogue
//{
//    public int ID;
//    public string Speaker;
//    public string DialogueText;

//    public Dialogue(int id, string speaker, string dialogueText)
//    {
//        ID = id;
//        Speaker = speaker;
//        DialogueText = dialogueText;
//    }
//}
