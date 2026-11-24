# UnityEngine.Rect GetPlantRect()

- 类：`Plant`
- 汇编行数：87

## 反汇编

```asm

Disassembly:
	cmp dword ptr [rdx+70h],17h
	je short 00000001806B1A66h
	cmp dword ptr [rdx+70h],1Eh
	je short 00000001806B1A4Fh
	cmp dword ptr [rdx+70h],2Fh
	movss xmm1,dword ptr [rdx+24h]
	movss xmm0,dword ptr [rdx+20h]
	movss dword ptr [rcx+4],xmm1
	je short 00000001806B1A39h
	addss xmm0,dword ptr [183C33DACh]
	mov eax,[rdx+28h]
	sub eax,14h
	movss dword ptr [rcx],xmm0
	movd xmm0,eax
	jmp short 00000001806B1A82h
	movss dword ptr [rcx],xmm0
	mov rax,rcx
	mov dword ptr [rcx+8],430C0000h
	mov dword ptr [rcx+0Ch],42A00000h
	ret
	mov eax,[rdx+20h]
	mov [rcx],eax
	mov eax,[rdx+24h]
	mov [rcx+4],eax
	mov eax,[rdx+28h]
	sub eax,14h
	movd xmm0,eax
	jmp short 00000001806B1A82h
	movss xmm0,dword ptr [rdx+20h]
	addss xmm0,dword ptr [183C33DACh]
	mov eax,[rdx+24h]
	mov [rcx+4],eax
	movss dword ptr [rcx],xmm0
	movd xmm0,dword ptr [rdx+28h]
	movd xmm1,dword ptr [rdx+2Ch]
	mov rax,rcx
	cvtdq2ps xmm1,xmm1
	cvtdq2ps xmm0,xmm0
	movss dword ptr [rcx+0Ch],xmm1
	movss dword ptr [rcx+8],xmm0
	ret

ISIL:
	001 Compare [rdx+112], 23
	002 JumpIfEqual {29}
	003 Compare [rdx+112], 30
	004 JumpIfEqual {21}
	005 Compare [rdx+112], 47
	006 Move xmm1, [rdx+36]
	007 Move xmm0, [rdx+32]
	008 Move [rcx+4], xmm1
	009 JumpIfEqual {16}
	010 Add xmm0, xmm0, [0x183C33DAC]
	011 Move rax, [rdx+40]
	012 Subtract rax, rax, 20
	013 Move [rcx], xmm0
	014 Move xmm0, rax
	015 Goto {35}
	016 Move [rcx], xmm0
	017 Move rax, rcx
	018 Move [rcx+8], 0x430C0000
	019 Move [rcx+12], 0x42A00000
	020 Return rax
	021 Move rax, [rdx+32]
	022 Move [rcx], rax
	023 Move rax, [rdx+36]
	024 Move [rcx+4], rax
	025 Move rax, [rdx+40]
	026 Subtract rax, rax, 20
	027 Move xmm0, rax
	028 Goto {35}
	029 Move xmm0, [rdx+32]
	030 Add xmm0, xmm0, [0x183C33DAC]
	031 Move rax, [rdx+36]
	032 Move [rcx+4], rax
	033 Move [rcx], xmm0
	034 Move xmm0, [rdx+40]
	035 Move xmm1, [rdx+44]
	036 Move rax, rcx
	037 Move xmm1, xmm1
	038 Move xmm0, xmm0
	039 Move [rcx+12], xmm1
	040 Move [rcx+8], xmm0
	041 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
