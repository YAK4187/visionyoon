
// MFCHWWDlg.cpp: 구현 파일
//

#include "pch.h"
#include "framework.h"
#include "MFCHWW.h"
#include "MFCHWWDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

#pragma region [1] 다이얼로그 및 초기화 관련 함수
// 응용 프로그램 정보에 사용되는 CAboutDlg 대화 상자입니다.

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 지원입니다.

// 구현입니다.
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CMFCHWWDlg 대화 상자

CMFCHWWDlg::CMFCHWWDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_MFCHWW_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CMFCHWWDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CMFCHWWDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_LBUTTONDOWN()  // 클릭 이벤트 등록
	ON_WM_MOUSEMOVE()    // 마우스 이동 이벤트 등록
	ON_WM_LBUTTONUP()    // 마우스 버튼 놓기 이벤트 등록
	ON_BN_CLICKED(IDC_BUTTON_RESET, &CMFCHWWDlg::OnBnClickedButtonReset)
	ON_BN_CLICKED(IDC_BUTTON_RANDOM, &CMFCHWWDlg::OnBnClickedButtonRandom)
	ON_BN_CLICKED(IDC_BUTTON_APPLY, &CMFCHWWDlg::OnBnClickedButtonApply)
	ON_WM_LBUTTONDOWN()
END_MESSAGE_MAP()


// CMFCHWWDlg 메시지 처리기

BOOL CMFCHWWDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 글씨 크기 변경 
	m_fontLarge.CreateFont(
		24,                // 글씨 높이
		0,                 // 너비 
		0, 0,              // 기울기 없음
		FW_BOLD,           // 굵기 
		FALSE, FALSE, FALSE, 
		ANSI_CHARSET,      // 문자 
		OUT_DEFAULT_PRECIS,
		CLIP_DEFAULT_PRECIS,
		DEFAULT_QUALITY,
		DEFAULT_PITCH | FF_SWISS,
		_T("Arial"));      // 원하는 글씨체 


	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != nullptr)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	//  클릭한 좌표를 표시할 Static 컨트롤을 다이얼로그와 연결
	m_staticPoint1.SubclassDlgItem(IDC_STATIC_POINT1, this);
	m_staticPoint2.SubclassDlgItem(IDC_STATIC_POINT2, this);
	m_staticPoint3.SubclassDlgItem(IDC_STATIC_POINT3, this);

	// Static Control에 폰트 적용
	GetDlgItem(IDC_STATIC_TEXT6)->SetFont(&m_fontLarge);  
	GetDlgItem(IDC_STATIC_TEXT7)->SetFont(&m_fontLarge);  
	GetDlgItem(IDC_STATIC_TEXT8)->SetFont(&m_fontLarge);  
	GetDlgItem(IDC_STATIC_TEXT9)->SetFont(&m_fontLarge);  
	GetDlgItem(IDC_STATIC_TEXT10)->SetFont(&m_fontLarge);  
	GetDlgItem(IDC_STATIC_POINT1)->SetFont(&m_fontLarge);  
	GetDlgItem(IDC_STATIC_POINT2)->SetFont(&m_fontLarge);  
	GetDlgItem(IDC_STATIC_POINT3)->SetFont(&m_fontLarge);  
	GetDlgItem(IDC_STATIC_TEXT9)->SetFont(&m_fontLarge);  

	// 초기 좌표 설정
	SetPointLabels();


	// 이 대화 상자의 아이콘을 설정합니다.  응용 프로그램의 주 창이 대화 상자가 아닐 경우에는
	//  프레임워크가 이 작업을 자동으로 수행합니다.
	SetIcon(m_hIcon, TRUE);			// 큰 아이콘을 설정합니다.
	SetIcon(m_hIcon, FALSE);		// 작은 아이콘을 설정합니다.

	// TODO: 여기에 추가 초기화 작업을 추가합니다.

	return TRUE;  // 포커스를 컨트롤에 설정하지 않으면 TRUE를 반환합니다.
}

void CMFCHWWDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}
#pragma endregion

#pragma region [2] 그리기 관련 함수
// 대화 상자에 최소화 단추를 추가할 경우 아이콘을 그리려면
//  아래 코드가 필요합니다.  문서/뷰 모델을 사용하는 MFC 애플리케이션의 경우에는
//  프레임워크에서 이 작업을 자동으로 수행합니다.

void CMFCHWWDlg::OnPaint()
{
	CPaintDC dc(this); // 그리기를 위한 디바이스 컨텍스트입니다.
	if (IsIconic())
	{
		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 클라이언트 사각형에서 아이콘을 가운데에 맞춥니다.
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 아이콘을 그립니다.
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		// 클릭한 점들을 검은색으로 채워진 원으로 그림
		CBrush blackBrush(RGB(0, 0, 0));  // 검은색 브러시 생성
		CBrush* pOldBrush = dc.SelectObject(&blackBrush);  // 기존 브러시 저장

		for (const auto& p : clickPoints) {
			dc.Ellipse(p.x - userRadius, p.y - userRadius, p.x + userRadius, p.y + userRadius);
		}

		dc.SelectObject(pOldBrush);  // 원래 브러시로 복구

		// 3개의 점을 기반으로 원(정원) 그리기
		if (clickPoints.size() == 3)
		{
			dc.SelectStockObject(NULL_BRUSH);  // 내부 비움

			// 두께 적용
			CPen pen(PS_SOLID, userThickness, RGB(0, 0, 0));
			CPen* pOldPen = dc.SelectObject(&pen);

			dc.Ellipse(circleCenter.x - circleRadius, circleCenter.y - circleRadius,
				circleCenter.x + circleRadius, circleCenter.y + circleRadius);

			dc.SelectObject(pOldPen);  // 펜 복구
		}
	}
}
#pragma endregion

#pragma region [3] 클릭 및 드래그 이벤트 처리
// 사용자가 최소화된 창을 끄는 동안에 커서가 표시되도록 시스템에서
//  이 함수를 호출합니다.
HCURSOR CMFCHWWDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CMFCHWWDlg::OnLButtonDown(UINT nFlags, CPoint point)
{
	// 클릭 전에 반지름과 두께가 설정되었는지 확인
	if (userRadius == 0 || userThickness == 0)
	{
		MessageBox(_T("반지름과 두께를 설정하세요."), _T("입력 오류"), MB_OK | MB_ICONERROR);
		return; // 클릭 무시
	}

	// 클릭한 점 드래그 가능 여부 확인
	for (size_t i = 0; i < clickPoints.size(); i++)
	{
		if (abs(clickPoints[i].x - point.x) < 10 && abs(clickPoints[i].y - point.y) < 10)
		{
			isDragging = true;
			selectedPointIndex = i;
			return;
		}
	}

	// 클릭 전에 반지름이 설정되어 있어야 함
	if (clickPoints.size() < 3)
	{
		clickPoints.push_back(point);
		SetPointLabels();
		if (clickPoints.size() == 3) CalculateCircle();
	}

	Invalidate();
}

void CMFCHWWDlg::OnLButtonUp(UINT nFlags, CPoint point)
{
	isDragging = false;
	selectedPointIndex = -1; // 드래그 해제

	CDialogEx::OnLButtonUp(nFlags, point);
}



void CMFCHWWDlg::OnMouseMove(UINT nFlags, CPoint point)
{
	if (isDragging && selectedPointIndex != -1)
	{
		clickPoints[selectedPointIndex] = point; // 선택된 점 이동
		SetPointLabels(); // 좌표 UI 업데이트
		CalculateCircle(); // 원 다시 계산
		Invalidate(); // 화면 다시 그리기
	}

	CDialogEx::OnMouseMove(nFlags, point);
}

#pragma endregion

#pragma region [4] 버튼 이벤트 처리
void CMFCHWWDlg::OnBnClickedButtonReset()
{
	clickPoints.clear();  // 클릭한 점 초기화
	Invalidate();
}

void CMFCHWWDlg::OnBnClickedButtonApply()
{
	CString radiusStr, thicknessStr;

	// Edit Control에서 값 가져오기
	GetDlgItemText(IDC_EDIT_RADIUS, radiusStr);
	GetDlgItemText(IDC_EDIT_THICKNESS, thicknessStr);

	// 문자열을 숫자로 변환
	int newRadius = _ttoi(radiusStr);
	int newThickness = _ttoi(thicknessStr);

	// 값 검증
	if (newRadius <= 0 || newRadius >= 100)
	{
		MessageBox(_T("반지름 값이 유효하지 않습니다! (1~99 사이 값을 입력하세요.)"), _T("입력 오류"), MB_OK | MB_ICONERROR);
		return; 
	}
	if (newThickness <= 0 || newThickness >= 20)
	{
		MessageBox(_T("선 두께 값이 유효하지 않습니다! (1~19 사이 값을 입력하세요.)"), _T("입력 오류"), MB_OK | MB_ICONERROR);
		return; 
	}

	//값이 정상적이면 적용
	userRadius = newRadius;
	userThickness = newThickness;

	UpdateRadiusAndThickness();
	Invalidate();
}
#pragma endregion

#pragma region [5] 랜덤 이동 기능
// 랜덤 좌표 생성 함수
CPoint CMFCHWWDlg::GetRandomPoint(int width, int height)
{
	std::random_device rd;
	std::mt19937 gen(rd());
	std::uniform_int_distribution<int> disX(50, width - 50);
	std::uniform_int_distribution<int> disY(50, height - 50);
	return CPoint(disX(gen), disY(gen));
}

void CMFCHWWDlg::OnBnClickedButtonRandom()
{
	if (clickPoints.size() < 3)
	{
		MessageBox(_T("랜덤 이동을 실행하려면 3개의 점이 필요합니다."), _T("알림"), MB_OK);
		return;
	}

	// 랜덤 이동을 별도의 스레드에서 실행
	AfxBeginThread(RandomMoveThread, this);
}

UINT CMFCHWWDlg::RandomMoveThread(LPVOID pParam)
{
	CMFCHWWDlg* pDlg = reinterpret_cast<CMFCHWWDlg*>(pParam);
	if (!pDlg) return 0;

	for (int i = 0; i < 10; i++)  // 10번 반복
	{
		// 랜덤한 좌표 생성
		CRect clientRect;
		pDlg->GetClientRect(&clientRect);

		for (auto& point : pDlg->clickPoints)
		{
			int x = rand() % (clientRect.Width() - 50) + 25;
			int y = rand() % (clientRect.Height() - 50) + 25;
			point = CPoint(x, y);
		}

		pDlg->CalculateCircle();  // 원 다시 계산
		pDlg->Invalidate(); 
		Sleep(500); //초당 2회 이동
	}

	return 0;
}
#pragma endregion

#pragma region [6] 원의 중심 및 반지름 계산
// 원의 중심과 반지름을 계산
void CMFCHWWDlg::CalculateCircle()
{
	if (clickPoints.size() < 3) return;

	double x1 = clickPoints[0].x, y1 = clickPoints[0].y;
	double x2 = clickPoints[1].x, y2 = clickPoints[1].y;
	double x3 = clickPoints[2].x, y3 = clickPoints[2].y;

	double A = x1 * (y2 - y3) - y1 * (x2 - x3) + x2 * y3 - x3 * y2;
	double B = (x1 * x1 + y1 * y1) * (y3 - y2) + (x2 * x2 + y2 * y2) * (y1 - y3) + (x3 * x3 + y3 * y3) * (y2 - y1);
	double C = (x1 * x1 + y1 * y1) * (x2 - x3) + (x2 * x2 + y2 * y2) * (x3 - x1) + (x3 * x3 + y3 * y3) * (x1 - x2);

	circleCenter.x = -B / (2 * A);
	circleCenter.y = -C / (2 * A);
	circleRadius = sqrt((circleCenter.x - x1) * (circleCenter.x - x1) + (circleCenter.y - y1) * (circleCenter.y - y1));
}
#pragma endregion

#pragma region [7] 클릭 지점 좌표 표시
void CMFCHWWDlg::SetPointLabels()
{
	if (clickPoints.size() > 0)
	{
		CString text;
		text.Format(_T("X: %d, Y: %d"), clickPoints[0].x, clickPoints[0].y);
		m_staticPoint1.SetWindowText(text);
	}
	if (clickPoints.size() > 1)
	{
		CString text;
		text.Format(_T("X: %d, Y: %d"), clickPoints[1].x, clickPoints[1].y);
		m_staticPoint2.SetWindowText(text);
	}
	if (clickPoints.size() > 2)
	{
		CString text;
		text.Format(_T("X: %d, Y: %d"), clickPoints[2].x, clickPoints[2].y);
		m_staticPoint3.SetWindowText(text);
	}
}

void CMFCHWWDlg::UpdateRadiusAndThickness()
{
	CString radiusStr, thicknessStr;
	GetDlgItemText(IDC_EDIT_RADIUS, radiusStr);
	GetDlgItemText(IDC_EDIT_THICKNESS, thicknessStr);

	int newRadius = _ttoi(radiusStr);
	int newThickness = _ttoi(thicknessStr);

	// 반지름 값 검증
	if (newRadius <= 0 || newRadius >= 100)
	{
		MessageBox(_T("반지름 값이 유효하지 않습니다! (1~99 사이 값을 입력하세요.)"), _T("입력 오류"), MB_OK | MB_ICONERROR);
		return; 
	}

	// 두께 값 검증
	if (newThickness <= 0 || newThickness >= 20)
	{
		MessageBox(_T("선 두께 값이 유효하지 않습니다! (1~19 사이 값을 입력하세요.)"), _T("입력 오류"), MB_OK | MB_ICONERROR);
		return; 
	}

	// 값이 정상적이면 적용
	userRadius = newRadius;
	userThickness = newThickness;
}
#pragma endregion