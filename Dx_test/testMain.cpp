#include "DxLib.h"
#include <iostream>
using namespace std;


/*�֐��錾*/
//�������o���B����悹(�������͍s�ԍ�)
void SimpleDraw(string drawText, int i);

// �v���O������ WinMain ����n�܂�܂�
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
	ChangeWindowMode(TRUE);//window���[�h

	if (DxLib_Init() == -1)	// �c�w���C�u��������������
	{
		return -1;
	}

	// ���F�̒l���擾
	unsigned int Cr = GetColor(255, 255, 255);
	// ������̕`��
	DrawString(250, 240 - 32, "Hello  World!", Cr);

	WaitKey();// �L�[���͑҂�

	DxLib_End();// �c�w���C�u�����g�p�̏I������

	return 0;// �\�t�g�̏I�� 
}


/*�֐���`*/
//�������o���B����悹(�������͍s�ԍ�)
void SimpleDraw(string drawText, int i)
{
	// ���F�̒l���擾
	unsigned int Cr = GetColor(255, 255, 255);
	// ������̕`��
	DrawString(0, i * 20, const_cast<char*>(drawText.c_str()), Cr);
}