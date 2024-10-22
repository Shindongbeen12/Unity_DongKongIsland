using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DilogExcelManager : MonoBehaviour
{
    public Excel dialogData; // 엑셀 데이터를 담고 있는 ScriptableObject
    public TMP_Text nameText;  // 이름 출력할 Text UI
    public TMP_Text dialogText;  // 대화 내용을 출력할 Text UI
    

    private int currentDialogIndex = 0; // 현재 대화 인덱스 

    void Start()
    {
        // 첫 번째 대화 출력
        ShowDialog(currentDialogIndex);
        Debug.Log("스토리 시작");
    }

    // 대화를 출력하는 함수
    public void ShowDialog(int dialogIndex)
    {
        if (dialogData != null && dialogData.Dialog1 != null && dialogIndex < dialogData.Dialog1.Count)
        {
            DialogEntity currentDialog = dialogData.Dialog1[dialogIndex];

            // ID를 문자열로 변환하여 출력
            nameText.text = currentDialog.Name;
            dialogText.text = currentDialog.Dialog;
        }
        else
        {
            Debug.Log("대화 데이터를 불러올 수 없거나 더 이상 대화가 없습니다.");
        }
    }

    // 다음 대화로 넘어가는 함수
    public void NextDialog()
    {
        if (currentDialogIndex < dialogData.Dialog1.Count - 1)
        {
            currentDialogIndex++;
            ShowDialog(currentDialogIndex);
        }
        else
        {
            Debug.Log("마지막 대화입니다.");
        }
    }
}
