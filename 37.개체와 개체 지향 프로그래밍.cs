using System;


class 개체지향프로그래밍
{
    static void Main(string[] args)
    {
        Console.WriteLine("37.개체 지향 프로그래밍");
        Console.WriteLine("개체 지향 프로그래밍의 목적ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("1.프로그램을 분석하기 쉬워진다.\n" +
                          "2.프로그램 유지보수가 쉬워진다.\n" +
                          "3.프로그램의 특정 기능을 재사용 할 수 있다.(Class의 개념이라)\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*개체");
        Console.WriteLine("클래스를 사용하여 새로운 형식을 정의하고,\n" +
                          "데이터와 기능을 숨기는 \"캡슐화\" 기능을 제공한다.");
        Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        
    }
}


//37-1 현실 세계의 자동차 설계도 및 자동차 개체 흉내 내기

class 개체_지향_프로그래밍
{
    static void Main(string[] args)
    {
        Console.WriteLine("*개체 지향 프로그래밍ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        Console.WriteLine("비유로 \'현실 세계를 프로그래밍 세계로 옮겨 놓는 행위\'가 적절하다.(다른 말로 '모델링'이라고 함)\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*클래스 == 설계도");
        Console.WriteLine("클래스는 개체, 컨트롤, 컴포넌트 등을 만들어 내는 설계도입니다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*개체(설계도로 만들어진 개체)");
        Console.WriteLine("현실 세계에서 어떤 특징(속성)을 가지며 어떤 동작(메서드)을 수행할 수 있는 단위 하나를 개체로 표현\n" +
                          "[빨간색 자동차 개체가 좌회전 동작을 한다] - (빨간색 자동차 == 어떤 특징(속성)), (좌회전 동작 == 어떤 동작(메서드))" +
                          "\nㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*필드(부품)");
        Console.WriteLine("필드는 클래스의 부품 역할을 하는 멤버 변수를 의미한다." +
                          "\nㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*생성자(시동 걸기)");
        Console.WriteLine("단어 그대로 개체를 생성하는 메서드이며, 생성자는 클래스 내 필드를 초기화하는 역할을 한다.\n" +
                          "생성자를 사용하는 클래스를 '인스턴스 클래스'라고 한다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*메서드(전진, 후진, 좌회전같은 동작)");
        Console.WriteLine("동작을 나타내며, 메서드 오버로드로 이름이 같은 메서드를 만들었고,\n" +
                          "메서드 오버라이드로 부모 클래스의 메서드를 새롭게 정의 할 수 있었다.\n" +
                          "메서드의 전달 방식으로 ref, out, in, params 등을 사용 할 수 있다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*속성(차의 색상, 모양같은 특징");
        Console.WriteLine("외부에 공개(public)하려는 부품을 나타낼 수 있고,\n" +
                          "private한 필드를 public한 속성으로 외부에 공개할 때 사용됨\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*인덱서(카탈로그/카테고리) - 속성의 배열형");
        Console.WriteLine("자신이 만든 개체를 배열 형식으로 사용할 수 있게 하는 개념이며\n" +
                          "인덱서는 정수형 인덱스를 사용하는 것과, 문자열 인덱스를 사용하는 것으로 구분함.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*대리자(대리운전)");
        Console.WriteLine("이름 하나로 여러 메서드를 묶어 실행하는 구조이며, \n" +
                          "이벤트를 만들어 내는 또 다른 중간 단계로 사용된다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*이벤트(사건 및 사고)");
        Console.WriteLine("마우스 클릭 이벤트같이 무엇인가 실행된 결과를 의미한다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*네임스페이스(클래스 이름의 충돌 방지)");
        Console.WriteLine("클래스 이름의 충돌을 방지하려고 클래스를 묶어 주는 개념으로 사용된다.,\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*인터페이스(표준 설계 역할)");
        Console.WriteLine("메서드 이름 등을 강제로 정의할 수 있고, 큰 프로그램의 골격(뼈대)을 만들어주는 개념\n" +
                          "그리고 부모로 다중 상속이 가능하게 하는 개념이다.\n" +
                          "ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

        Console.WriteLine("*특성(클래스 자체에 대한 설명)");
        Console.WriteLine("클래스 자체에 대한 설명(메타데이터)를 붙이는 역할이다.");






    }
}

