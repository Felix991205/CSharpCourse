class Test
{
	int x;
	static int y;
	void F() {
		this.x = 1;			// Ok���൱�� this.x = 1
		Test.y = 1;			// Ok���൱�� Test.y = 1
	}
	static void G() {
		//x = 1;			// ���󣬲��ܷ��� this.x
		Test.y = 1;			// Ok���൱�� Test.y = 1
	}
	static void Main() {
		Test t = new Test();
		t.x = 1;		// Ok
		//t.y = 1;		// ���󣬲����ö���������static��Ա
		//Test.x = 1;		// ���󣬲�������������ʵ����Ա
		Test.y = 1;		// Ok
        t.F();
        Test.G();
	}
}
