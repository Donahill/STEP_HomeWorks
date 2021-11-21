using System;

namespace ComplexDigit
{

	class Complex
	{
		double m_re, m_im;

		public Complex(double re = 1, double im = 0)
		{
			m_re = re;
			m_im = im;
		}

		public static Complex operator +(Complex a, Complex b)
		{
			return new Complex(a.m_re + b.m_re, a.m_im + b.m_im);
		}

		public static Complex operator -(Complex a, Complex b)
		{
			return Complex(a.m_re - b.m_re, a.m_im - b.m_im);
		}

		public static Complex operator *(Complex a, Complex b)
		{
			return Complex(a.m_re * b.m_re - a.m_im * b.m_im, a.m_re * b.m_im - a.m_im * b.m_re);
		}

		public static Complex operator /(Complex a, Complex b)
		{
			return Complex((a.m_re * b.m_re + a.m_im * b.m_im) / (a.m_im * a.m_im + b.m_im * b.m_im), (a.m_im * b.m_re - a.m_re * b.m_im) / (b.m_re * b.m_re + b.m_im * b.m_im));
		}
	}
}
