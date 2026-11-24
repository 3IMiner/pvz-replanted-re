# System.Void UpdateTanglekelp()

- 类：`Plant`
- 汇编行数：342

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB66Ch],0
	mov rbx,rcx
	jne short 00000001806BDCB1h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C6D900h]
	call 00000001804FEB70h
	mov byte ptr [184EEB66Ch],1
	cmp dword ptr [rbx+88h],22h
	mov [rsp+40h],rsi
	mov [rsp+48h],rdi
	jne near ptr 00000001806BDE47h
	cmp dword ptr [rbx+0A0h],32h
	jne short 00000001806BDD0Bh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BDF58h
	mov edx,[rbx+120h]
	xor r8d,r8d
	call 0000000180677050h
	mov rdi,rax
	test rax,rax
	je short 00000001806BDD0Bh
	xor edx,edx
	mov rcx,rax
	call 00000001806EC590h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 00000001806F5850h
	cmp dword ptr [rbx+0A0h],14h
	jne near ptr 00000001806BDDFAh
	mov edx,[rbx+34h]
	xor r9d,r9d
	mov r8d,6
	mov ecx,4AF38h
	call 0000000180665070h
	mov rcx,[rbx+10h]
	mov edi,eax
	test rcx,rcx
	je near ptr 00000001806BDF58h
	movss xmm2,dword ptr [rbx+24h]
	xor esi,esi
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,eax
	addss xmm2,dword ptr [183C33ED8h]
	subss xmm1,dword ptr [183C33EECh]
	mov [rsp+28h],rsi
	mov dword ptr [rsp+20h],20h
	call 00000001807D96D0h
	test rax,rax
	je near ptr 00000001806BDF58h
	movss xmm1,dword ptr [183C33D90h]
	xor r9d,r9d
	movaps xmm2,xmm1
	mov rcx,rax
	call 00000001806CA790h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BDF58h
	movss xmm2,dword ptr [rbx+24h]
	mov r9d,edi
	movss xmm1,dword ptr [rbx+20h]
	addss xmm2,dword ptr [183C33FE8h]
	addss xmm1,dword ptr [183C33FC0h]
	mov [rsp+28h],rsi
	mov dword ptr [rsp+20h],16h
	call 00000001807D9B50h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806BDF58h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806BDF58h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,35h
	call 0000000180002040h
	cmp dword ptr [rbx+0A0h],0
	jne short 00000001806BDE37h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BDF58h
	mov edx,[rbx+120h]
	xor r8d,r8d
	call 0000000180677050h
	test rax,rax
	je short 00000001806BDE37h
	xor edx,edx
	mov rcx,rax
	call 00000001806EC320h
	mov rdi,[rsp+48h]
	mov rsi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	mov rdi,rax
	test rax,rax
	je short 00000001806BDE37h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806BDF58h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806BDF58h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,44h
	call 0000000180002040h
	xor r8d,r8d
	mov dword ptr [rbx+88h],22h
	xor edx,edx
	mov dword ptr [rbx+0A0h],64h
	mov rcx,rdi
	call 00000001806F5850h
	mov rcx,[rdi+1D0h]
	test rcx,rcx
	je near ptr 00000001806BDF58h
	xor edx,edx
	call 00000001807C8D30h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BDF58h
	mov r9d,[rdi+38h]
	xor esi,esi
	mov [rsp+28h],rsi
	xorps xmm2,xmm2
	xorps xmm1,xmm1
	mov dword ptr [rsp+20h],98h
	call 00000001807D96D0h
	mov rsi,rax
	test rax,rax
	je short 00000001806BDF2Eh
	mov ecx,[rax+6Ch]
	xor edx,edx
	call 00000001806BE7D0h
	mov [rbx+13Ch],eax
	mov rcx,[rsi+0D0h]
	test rcx,rcx
	je short 00000001806BDF58h
	mov r8,[184C6D900h]
	xor r9d,r9d
	mov rdx,[rdi+1D0h]
	call 00000001807C7500h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806BDF58h
	xor r8d,r8d
	mov rdx,rdi
	call 0000000180676EB0h
	mov rdi,[rsp+48h]
	mov rsi,[rsp+40h]
	mov [rbx+120h],eax
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB66C], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {12}
	007 LoadAddress rcx, [0x184C75168]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C6D900]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 Move [0x184EEB66C], 1
	012 Compare [rbx+136], 34
	013 Move stack:0x40, rsi
	014 Move stack:0x48, rdi
	015 JumpIfNotEqual {104}
	016 Compare [rbx+160], 50
	017 JumpIfNotEqual {34}
	018 Move rcx, [rbx+24]
	019 Compare rcx, 0
	020 JumpIfEqual {170}
	021 Move rdx, [rbx+288]
	022 Move r8, 0
	023 Call Board.ZombieTryToGet, rcx, rdx
	024 Move rdi, rax
	025 Compare rax, 0
	026 JumpIfEqual {34}
	027 Move rdx, 0
	028 Move rcx, rax
	029 Call Zombie.DragUnder, rcx, rdx
	030 Move r8, 0
	031 Move rdx, 0
	032 Move rcx, rdi
	033 Call Zombie.PoolSplash, rcx, rdx
	034 Compare [rbx+160], 20
	035 JumpIfNotEqual {82}
	036 Move rdx, [rbx+52]
	037 Move r9, 0
	038 Move r8, 6
	039 Move rcx, 0x4AF38
	040 Call Board.MakeRenderOrder, rcx, rdx, r8, r9
	041 Move rcx, [rbx+16]
	042 Move rdi, rax
	043 Compare rcx, 0
	044 JumpIfEqual {170}
	045 Move xmm2, [rbx+36]
	046 Move rsi, 0
	047 Move xmm1, [rbx+32]
	048 Move r9, rax
	049 Add xmm2, xmm2, [0x183C33ED8]
	050 Subtract xmm1, xmm1, [0x183C33EEC]
	051 Move stack:0x28, rsi
	052 Move stack:0x20, 32
	053 Call GameplayActivity.AddReanimation, rcx, xmm1, r8, r9, stack:0x0
	054 Compare rax, 0
	055 JumpIfEqual {170}
	056 Move xmm1, [0x183C33D90]
	057 Move r9, 0
	058 Move xmm2, xmm1
	059 Move rcx, rax
	060 Call Reanimation.OverrideScale, rcx, xmm1, r8
	061 Move rcx, [rbx+16]
	062 Compare rcx, 0
	063 JumpIfEqual {170}
	064 Move xmm2, [rbx+36]
	065 Move r9, rdi
	066 Move xmm1, [rbx+32]
	067 Add xmm2, xmm2, [0x183C33FE8]
	068 Add xmm1, xmm1, [0x183C33FC0]
	069 Move stack:0x28, rsi
	070 Move stack:0x20, 22
	071 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	072 Move r8, [rbx+16]
	073 Compare r8, 0
	074 JumpIfEqual {170}
	075 Move r8, [r8+88]
	076 Compare r8, 0
	077 JumpIfEqual {170}
	078 Move rdx, typeof(Reloaded.Services.IAudioService)
	079 Move rcx, 6
	080 Move r9, 53
	081 Call 0x180002040, rcx, rdx, r8, r9
	082 Compare [rbx+160], 0
	083 JumpIfNotEqual {98}
	084 Move rdx, 0
	085 Move rcx, rbx
	086 Call Plant.Die, rcx, rdx
	087 Move rcx, [rbx+24]
	088 Compare rcx, 0
	089 JumpIfEqual {170}
	090 Move rdx, [rbx+288]
	091 Move r8, 0
	092 Call Board.ZombieTryToGet, rcx, rdx
	093 Compare rax, 0
	094 JumpIfEqual {98}
	095 Move rdx, 0
	096 Move rcx, rax
	097 Call Zombie.DieWithLoot, rcx, rdx
	098 Move rdi, stack:0x48
	099 Move rsi, stack:0x40
	100 ShiftStack 48
	101 Move rbx, stack:0x0
	102 ShiftStack 8
	103 Return 
	104 Move rdx, [rbx+52]
	105 Move r9, 0
	106 Move r8, 0
	107 Move rcx, rbx
	108 Call Plant.FindTargetZombie, rcx, rdx, r8
	109 Move rdi, rax
	110 Compare rax, 0
	111 JumpIfEqual {98}
	112 Move rax, [rbx+16]
	113 Compare rax, 0
	114 JumpIfEqual {170}
	115 Move r8, [rax+88]
	116 Compare r8, 0
	117 JumpIfEqual {170}
	118 Move rdx, typeof(Reloaded.Services.IAudioService)
	119 Move rcx, 6
	120 Move r9, 68
	121 Call 0x180002040, rcx, rdx, r8, r9
	122 Move r8, 0
	123 Move [rbx+136], 34
	124 Move rdx, 0
	125 Move [rbx+160], 100
	126 Move rcx, rdi
	127 Call Zombie.PoolSplash, rcx, rdx
	128 Move rcx, [rdi+464]
	129 Compare rcx, 0
	130 JumpIfEqual {170}
	131 Move rdx, 0
	132 Call ReloadedController.ApplyDefaultMaterialToOverrides, rcx, rdx
	133 Move rcx, [rbx+16]
	134 Compare rcx, 0
	135 JumpIfEqual {170}
	136 Move r9, [rdi+56]
	137 Move rsi, 0
	138 Move stack:0x28, rsi
	139 Move xmm2, 0
	140 Move xmm1, 0
	141 Move stack:0x20, 152
	142 Call GameplayActivity.AddReanimation, rcx, xmm1, r8, r9, stack:0x0
	143 Move rsi, rax
	144 Compare rax, 0
	145 JumpIfEqual {157}
	146 Move rcx, [rax+108]
	147 Move rdx, 0
	148 Call 0x1806BE7D0, rcx, rdx
	149 Move [rbx+316], rax
	150 Move rcx, [rsi+208]
	151 Compare rcx, 0
	152 JumpIfEqual {170}
	153 Move r8, "root"
	154 Move r9, 0
	155 Move rdx, [rdi+464]
	156 Call ReloadedCharacterController.AttachToBone, rcx, rdx, r8
	157 Move rcx, [rbx+24]
	158 Compare rcx, 0
	159 JumpIfEqual {170}
	160 Move r8, 0
	161 Move rdx, rdi
	162 Call Board.ZombieGetID, rcx, rdx
	163 Move rdi, stack:0x48
	164 Move rsi, stack:0x40
	165 Move [rbx+288], rax
	166 ShiftStack 48
	167 Move rbx, stack:0x0
	168 ShiftStack 8
	169 Return 
	170 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
