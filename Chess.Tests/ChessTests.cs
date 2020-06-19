using System;
using Xunit;
using Chess;

namespace Chess.Tests
{
    public class ChessTests
    {
        [Fact]
        public void PawnEatsRookTest()
        {
            Figure figure = new Pawn("�����");
            Figure figure1 = new Rook("������");
            Assert.Equal("������ ����� (�����) ������� ����� (������)", figure.Eat(figure1));
        }

        [Fact]
        public void KnightEatsRookTest()
        {
            Figure figure = new Knight("������");
            Figure figure1 = new Rook("�����");
            Assert.Equal("������ ���� (������) ������� ����� (������������ ���� (������) ������� ����� (�����)", figure.Eat(figure1));
        }

        [Fact]
        public void RookEatsPawnTest()
        {
            Figure figure = new Rook("������");
            Figure figure1 = new Pawn("�����");
            Assert.Equal("������ ����� (������) ������� ����� (�����)", figure.Eat(figure1));
        }

        [Fact]
        public void SameColorTest()
        {
            Figure figure = new Rook("������");
            Figure figure1 = new Pawn("������");
            Assert.Equal("������ ������ ������ ���� �� �����", figure.Eat(figure1));
        }

        [Fact]
        public void WalksTest()
        {
            Figure figure = new Pawn("������");
            Figure figure1 = new Rook("������");
            Figure figure2 = new Knight("������");
            Assert.Equal("����� ����� �� ������ �� ���� ������, ��� ������ ����� ��������� �� ��� ������", figure.Walk());
            Assert.Equal("����� ����� ����� �� ��������� � ����������� � ��� �������", figure1.Walk());
            Assert.Equal("���� ����� ������ �, ������������ �� ��� ������ � ����� ���������� �� ���� ���� ������ ��� �������", figure2.Walk());
        }
    }
}
