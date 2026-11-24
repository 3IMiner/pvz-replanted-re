# System.Void Reset()

- 类：`Plant`
- 汇编行数：160

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	xor edx,edx
	mov rbx,rcx
	call 00000001806CE570h
	xor edi,edi
	mov dword ptr [rbx+70h],0FFFFFFFFh
	mov [rbx+74h],rdi
	xorps xmm0,xmm0
	mov [rbx+7Ch],rdi
	xorps xmm1,xmm1
	mov [rbx+84h],rdi
	xor edx,edx
	mov [rbx+8Ch],rdi
	xor ecx,ecx
	mov [rbx+94h],rdi
	mov [rbx+9Ch],rdi
	mov [rbx+0A4h],rdi
	movups [rbx+0ACh],xmm0
	movups [rbx+0BCh],xmm1
	mov [rbx+0CCh],rdi
	mov [rbx+0D4h],edi
	call 00000001806BE7D0h
	xor edx,edx
	mov [rbx+0D8h],eax
	xor ecx,ecx
	mov [rbx+0DCh],edi
	call 00000001806BE7D0h
	xor edx,edx
	mov [rbx+0E0h],eax
	xor ecx,ecx
	call 00000001806BE7D0h
	xor edx,edx
	mov [rbx+0E4h],eax
	xor ecx,ecx
	call 00000001806BE7D0h
	xor edx,edx
	mov [rbx+0E8h],eax
	xor ecx,ecx
	call 00000001806BE7D0h
	xor edx,edx
	mov [rbx+0ECh],eax
	xor ecx,ecx
	call 00000001806BE7D0h
	xor edx,edx
	mov [rbx+0F0h],eax
	xor ecx,ecx
	call 00000001806BE7D0h
	xor edx,edx
	mov [rbx+0F4h],eax
	xor ecx,ecx
	call 00000001806BE7D0h
	xor edx,edx
	mov [rbx+0F8h],eax
	xor ecx,ecx
	mov [rbx+0FCh],rdi
	mov [rbx+104h],rdi
	mov [rbx+10Ch],rdi
	call 00000001806BE7D0h
	lea rcx,[rbx+140h]
	mov [rbx+120h],eax
	xor edx,edx
	mov [rbx+124h],rdi
	mov dword ptr [rbx+12Ch],0FFFFFFFFh
	mov [rbx+130h],rdi
	mov [rbx+138h],dil
	mov [rbx+140h],rdi
	call 00000001804FDEA0h
	lea rcx,[rbx+148h]
	mov [rbx+148h],rdi
	xor edx,edx
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	jmp near ptr 00000001804FDEA0h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -32
	005 Move rdx, 0
	006 Move rbx, rcx
	007 Call ReloadedObject.Reset, rcx, rdx
	008 Move rdi, 0
	009 Move [rbx+112], 0xFFFFFFFF
	010 Move [rbx+116], rdi
	011 Move xmm0, 0
	012 Move [rbx+124], rdi
	013 Move xmm1, 0
	014 Move [rbx+132], rdi
	015 Move rdx, 0
	016 Move [rbx+140], rdi
	017 Move rcx, 0
	018 Move [rbx+148], rdi
	019 Move [rbx+156], rdi
	020 Move [rbx+164], rdi
	021 Move [rbx+172], xmm0
	022 Move [rbx+188], xmm1
	023 Move [rbx+204], rdi
	024 Move [rbx+212], rdi
	025 Call 0x1806BE7D0, rcx, rdx
	026 Move rdx, 0
	027 Move [rbx+216], rax
	028 Move rcx, 0
	029 Move [rbx+220], rdi
	030 Call 0x1806BE7D0, rcx, rdx
	031 Move rdx, 0
	032 Move [rbx+224], rax
	033 Move rcx, 0
	034 Call 0x1806BE7D0, rcx, rdx
	035 Move rdx, 0
	036 Move [rbx+228], rax
	037 Move rcx, 0
	038 Call 0x1806BE7D0, rcx, rdx
	039 Move rdx, 0
	040 Move [rbx+232], rax
	041 Move rcx, 0
	042 Call 0x1806BE7D0, rcx, rdx
	043 Move rdx, 0
	044 Move [rbx+236], rax
	045 Move rcx, 0
	046 Call 0x1806BE7D0, rcx, rdx
	047 Move rdx, 0
	048 Move [rbx+240], rax
	049 Move rcx, 0
	050 Call 0x1806BE7D0, rcx, rdx
	051 Move rdx, 0
	052 Move [rbx+244], rax
	053 Move rcx, 0
	054 Call 0x1806BE7D0, rcx, rdx
	055 Move rdx, 0
	056 Move [rbx+248], rax
	057 Move rcx, 0
	058 Move [rbx+252], rdi
	059 Move [rbx+260], rdi
	060 Move [rbx+268], rdi
	061 Call 0x1806BE7D0, rcx, rdx
	062 LoadAddress rcx, [rbx+320]
	063 Move [rbx+288], rax
	064 Move rdx, 0
	065 Move [rbx+292], rdi
	066 Move [rbx+300], 0xFFFFFFFF
	067 Move [rbx+304], rdi
	068 Move [rbx+312], rdi
	069 Move [rbx+320], rdi
	070 Call 0x1804FDEA0, rcx, rdx, r8, r9
	071 LoadAddress rcx, [rbx+328]
	072 Move [rbx+328], rdi
	073 Move rdx, 0
	074 Move rbx, stack:0x30
	075 ShiftStack 32
	076 Move rdi, stack:0x0
	077 ShiftStack 8
	078 Call 0x1804FDEA0, rcx, rdx, r8, r9
	079 Return
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
