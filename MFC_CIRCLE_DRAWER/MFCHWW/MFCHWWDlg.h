
// MFCHWWDlg.h: 헤더 파일
//

#pragma once
#include <vector>
#include <random>


// CMFCHWWDlg 대화 상자
class CMFCHWWDlg : public CDialogEx
{
	void SetPointLabels();

// 생성입니다.
public:
	CMFCHWWDlg(CWnd* pParent = nullptr);	// 표준 생성자입니다.

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MFCHWW_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 지원입니다.


// 구현입니다.
protected:
	HICON m_hIcon;

	// 생성된 메시지 맵 함수
	void UpdateRadiusAndThickness();
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnMouseMove(UINT nFlags, CPoint point);
	afx_msg void OnLButtonUp(UINT nFlags, CPoint point);
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnBnClickedButtonApply();
		DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedButtonReset();
	afx_msg void OnBnClickedButtonRandom();


private:
	std::vector<CPoint> clickPoints;
	CPoint GetRandomPoint(int width, int height);  // 랜덤 좌표 생성 함수 선언
	CPoint circleCenter;
	double circleRadius = 0;
	int lineWidth = 2;
	void CalculateCircle(); // 원의 중심과 반지름을 계산하는 함수
	bool isDragging = false;    // 드래그 중인지 여부
	int selectedPointIndex = -1; // 선택된 클릭 점의 인덱스
	static UINT RandomMoveThread(LPVOID pParam); // 랜덤 이동을 수행할 스레드 함수
	int userRadius = 0;     //  반지름 
	int userThickness =0;   // 선 두께 
	CStatic m_staticPoint1;
	CStatic m_staticPoint2;
	CStatic m_staticPoint3;
	CFont  m_fontLarge;  //폰트 객체 추가
};
