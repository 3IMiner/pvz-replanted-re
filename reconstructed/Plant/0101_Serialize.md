# System.Void Serialize(ref Source.Serialization.ReloadedBinaryWriter writer, System.Int32 version)

- 类：`Plant`
- 汇编行数：753

## 反汇编

```asm

Disassembly:
	mov [rsp+18h],r8d
	push rbx
	push rdi
	push r15
	sub rsp,60h
	cmp byte ptr [184EEB67Ch],0
	mov r15d,r8d
	mov rbx,rdx
	mov rdi,rcx
	jne short 00000001806B5112h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184C69BB8h]
	call 00000001804FEB70h
	lea rcx,[184C69C90h]
	call 00000001804FEB70h
	lea rcx,[184C69D60h]
	call 00000001804FEB70h
	lea rcx,[184C6A4D8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB67Ch],1
	mov [rsp+88h],rbp
	xor r9d,r9d
	mov [rsp+58h],rsi
	mov r8d,r15d
	mov [rsp+50h],r12
	mov rdx,rbx
	mov [rsp+48h],r13
	mov rcx,rdi
	mov [rsp+40h],r14
	call 00000001806CE5A0h
	mov edx,[rdi+70h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+74h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+78h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+7Ch]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+80h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+84h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+88h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+8Ch]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+90h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+94h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+98h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+9Ch]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0A0h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0A4h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0A8h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	movups xmm0,[rdi+0ACh]
	xor r8d,r8d
	lea rdx,[rsp+20h]
	mov rcx,rbx
	movaps [rsp+20h],xmm0
	call 00000001806AAF00h
	movups xmm0,[rdi+0BCh]
	xor r8d,r8d
	lea rdx,[rsp+20h]
	mov rcx,rbx
	movaps [rsp+20h],xmm0
	call 00000001806AAF00h
	mov edx,[rdi+0CCh]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0D0h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0D4h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0D8h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0DCh]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0F4h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0F8h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+0FCh]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+100h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+104h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+108h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	movss xmm1,dword ptr [rdi+10Ch]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018060DAE0h
	movss xmm1,dword ptr [rdi+110h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018060DAE0h
	mov edx,[rdi+120h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+124h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+128h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+12Ch]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov edx,[rdi+130h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	movzx edx,byte ptr [rdi+134h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BAB0h
	movzx edx,byte ptr [rdi+135h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BAB0h
	movzx edx,byte ptr [rdi+136h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BAB0h
	movzx edx,byte ptr [rdi+137h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BAB0h
	movzx edx,byte ptr [rdi+138h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BAB0h
	movzx edx,byte ptr [rdi+139h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BAB0h
	mov edx,[rdi+13Ch]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov rdx,[rdi+140h]
	test rdx,rdx
	je near ptr 00000001806B56E7h
	movzx edx,byte ptr [rdx+170h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BAB0h
	mov rdx,[rdi+140h]
	test rdx,rdx
	je near ptr 00000001806B56E7h
	movzx edx,byte ptr [rdx+171h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BAB0h
	mov rcx,[rdi+140h]
	test rcx,rcx
	je near ptr 00000001806B56E7h
	mov r9,[rcx]
	mov r8d,r15d
	mov rdx,rbx
	mov rax,[r9+288h]
	mov r9,[r9+290h]
	call rax
	mov rdx,[rdi+118h]
	test rdx,rdx
	je near ptr 00000001806B56E7h
	mov edx,[rdx+18h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov rcx,[rdi+118h]
	xor edx,edx
	xor esi,esi
	test rcx,rcx
	je near ptr 00000001806B56E7h
	mov r14d,20h
	mov rax,rcx
	mov ebp,r14d
	cmp edx,[rcx+18h]
	jge short 00000001806B5517h
	test rax,rax
	je near ptr 00000001806B56E7h
	cmp esi,[rax+18h]
	jae near ptr 00000001806B56EDh
	mov rcx,[rax+rbp]
	test rcx,rcx
	je near ptr 00000001806B56E7h
	xor r9d,r9d
	mov r8d,r15d
	mov rdx,rbx
	call 00000001806C52B0h
	mov rax,[rdi+118h]
	inc esi
	add rbp,8
	mov edx,esi
	mov rcx,rax
	test rax,rax
	je near ptr 00000001806B56E7h
	jmp short 00000001806B54C8h
	mov rdx,[rdi+150h]
	test rdx,rdx
	je near ptr 00000001806B56E7h
	mov edx,[rdx+18h]
	xor r8d,r8d
	mov rcx,rbx
	call 000000018063BD40h
	mov rax,[rdi+150h]
	xor ecx,ecx
	xor esi,esi
	test rax,rax
	je near ptr 00000001806B56E7h
	nop dword ptr [rax]
	cmp ecx,[rax+18h]
	jge near ptr 00000001806B56C2h
	mov rax,[rdi+150h]
	test rax,rax
	je near ptr 00000001806B56E7h
	cmp esi,[rax+18h]
	jae near ptr 00000001806B56EDh
	mov rcx,[184C2D478h]
	mov rbp,[r14+rax]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B558Bh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbp
	call 0000000183832900h
	cmp byte ptr [184EEB4ADh],0
	movzx r13d,al
	jne short 00000001806B55C4h
	lea rcx,[184C94098h]
	call 00000001804FEB70h
	lea rcx,[184C57A00h]
	call 00000001804FEB70h
	mov byte ptr [184EEB4ADh],1
	movsxd r15,dword ptr [rbx+10h]
	mov rax,[184C57A00h]
	mov [rsp+80h],rax
	cmp r15d,[rbx+8]
	jbe short 00000001806B55ECh
	xor ecx,ecx
	call 0000000182C05BF0h
	mov rax,[rsp+80h]
	mov rcx,[rax+20h]
	mov r12,r15
	add r12,[rbx]
	mov ebp,[rbx+8]
	mov dword ptr [rsp+2Ch],0
	test byte ptr [rcx+135h],1
	jne short 00000001806B560Fh
	call 00000001804FC300h
	sub ebp,r15d
	mov [rsp+20h],r12
	cmp byte ptr [184EEB4C1h],0
	mov [rsp+28h],ebp
	jne short 00000001806B5643h
	lea rcx,[184C92D30h]
	call 00000001804FEB70h
	lea rcx,[184C57D70h]
	call 00000001804FEB70h
	mov byte ptr [184EEB4C1h],1
	cmp ebp,1
	jae short 00000001806B5654h
	xor edx,edx
	mov ecx,1Ch
	call 0000000182C05BC0h
	movaps xmm0,[rsp+20h]
	lea rcx,[rsp+30h]
	mov rdx,[184C92D30h]
	movdqa [rsp+30h],xmm0
	call 0000000180721DA0h
	mov [rax],r13b
	inc dword ptr [rbx+10h]
	test r13b,r13b
	je short 00000001806B56A8h
	mov rax,[rdi+150h]
	test rax,rax
	je short 00000001806B56E7h
	cmp esi,[rax+18h]
	jae short 00000001806B56EDh
	mov rcx,[r14+rax]
	test rcx,rcx
	je short 00000001806B56E7h
	mov r8d,[rsp+90h]
	xor r9d,r9d
	mov rdx,rbx
	call 00000001807B4640h
	mov rax,[rdi+150h]
	inc esi
	add r14,8
	mov ecx,esi
	test rax,rax
	jne near ptr 00000001806B5550h
	jmp short 00000001806B56E7h
	mov r14,[rsp+40h]
	mov r13,[rsp+48h]
	mov r12,[rsp+50h]
	mov rsi,[rsp+58h]
	mov rbp,[rsp+88h]
	add rsp,60h
	pop r15
	pop rdi
	pop rbx
	ret
	call 00000001804FEE20h
	int 3
	call 00000001804FEE10h

ISIL:
	001 Move stack:0x18, r8
	002 ShiftStack -8
	003 Move stack:0x0, rbx
	004 ShiftStack -8
	005 Move stack:0x0, rdi
	006 ShiftStack -8
	007 Move stack:0x0, r15
	008 ShiftStack -96
	009 Compare [0x184EEB67C], 0
	010 Move r15, r8
	011 Move rbx, rdx
	012 Move rdi, rcx
	013 JumpIfNotEqual {25}
	014 LoadAddress rcx, [0x184C2D478]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 LoadAddress rcx, [0x184C69BB8]
	017 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	018 LoadAddress rcx, [0x184C69C90]
	019 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	020 LoadAddress rcx, [0x184C69D60]
	021 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	022 LoadAddress rcx, [0x184C6A4D8]
	023 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	024 Move [0x184EEB67C], 1
	025 Move stack:0x88, rbp
	026 Move r9, 0
	027 Move stack:0x58, rsi
	028 Move r8, r15
	029 Move stack:0x50, r12
	030 Move rdx, rbx
	031 Move stack:0x48, r13
	032 Move rcx, rdi
	033 Move stack:0x40, r14
	034 Call ReloadedObject.Serialize, rcx, rdx, r8
	035 Move rdx, [rdi+112]
	036 Move r8, 0
	037 Move rcx, rbx
	038 Call 0x18063BD40, rcx, rdx, r8, r9
	039 Move rdx, [rdi+116]
	040 Move r8, 0
	041 Move rcx, rbx
	042 Call 0x18063BD40, rcx, rdx, r8, r9
	043 Move rdx, [rdi+120]
	044 Move r8, 0
	045 Move rcx, rbx
	046 Call 0x18063BD40, rcx, rdx, r8, r9
	047 Move rdx, [rdi+124]
	048 Move r8, 0
	049 Move rcx, rbx
	050 Call 0x18063BD40, rcx, rdx, r8, r9
	051 Move rdx, [rdi+128]
	052 Move r8, 0
	053 Move rcx, rbx
	054 Call 0x18063BD40, rcx, rdx, r8, r9
	055 Move rdx, [rdi+132]
	056 Move r8, 0
	057 Move rcx, rbx
	058 Call 0x18063BD40, rcx, rdx, r8, r9
	059 Move rdx, [rdi+136]
	060 Move r8, 0
	061 Move rcx, rbx
	062 Call 0x18063BD40, rcx, rdx, r8, r9
	063 Move rdx, [rdi+140]
	064 Move r8, 0
	065 Move rcx, rbx
	066 Call 0x18063BD40, rcx, rdx, r8, r9
	067 Move rdx, [rdi+144]
	068 Move r8, 0
	069 Move rcx, rbx
	070 Call 0x18063BD40, rcx, rdx, r8, r9
	071 Move rdx, [rdi+148]
	072 Move r8, 0
	073 Move rcx, rbx
	074 Call 0x18063BD40, rcx, rdx, r8, r9
	075 Move rdx, [rdi+152]
	076 Move r8, 0
	077 Move rcx, rbx
	078 Call 0x18063BD40, rcx, rdx, r8, r9
	079 Move rdx, [rdi+156]
	080 Move r8, 0
	081 Move rcx, rbx
	082 Call 0x18063BD40, rcx, rdx, r8, r9
	083 Move rdx, [rdi+160]
	084 Move r8, 0
	085 Move rcx, rbx
	086 Call 0x18063BD40, rcx, rdx, r8, r9
	087 Move rdx, [rdi+164]
	088 Move r8, 0
	089 Move rcx, rbx
	090 Call 0x18063BD40, rcx, rdx, r8, r9
	091 Move rdx, [rdi+168]
	092 Move r8, 0
	093 Move rcx, rbx
	094 Call 0x18063BD40, rcx, rdx, r8, r9
	095 Move xmm0, [rdi+172]
	096 Move r8, 0
	097 LoadAddress rdx, stack:0x20
	098 Move rcx, rbx
	099 Move stack:0x20, xmm0
	100 Call 0x1806AAF00, rcx, rdx, r8, r9
	101 Move xmm0, [rdi+188]
	102 Move r8, 0
	103 LoadAddress rdx, stack:0x20
	104 Move rcx, rbx
	105 Move stack:0x20, xmm0
	106 Call 0x1806AAF00, rcx, rdx, r8, r9
	107 Move rdx, [rdi+204]
	108 Move r8, 0
	109 Move rcx, rbx
	110 Call 0x18063BD40, rcx, rdx, r8, r9
	111 Move rdx, [rdi+208]
	112 Move r8, 0
	113 Move rcx, rbx
	114 Call 0x18063BD40, rcx, rdx, r8, r9
	115 Move rdx, [rdi+212]
	116 Move r8, 0
	117 Move rcx, rbx
	118 Call 0x18063BD40, rcx, rdx, r8, r9
	119 Move rdx, [rdi+216]
	120 Move r8, 0
	121 Move rcx, rbx
	122 Call 0x18063BD40, rcx, rdx, r8, r9
	123 Move rdx, [rdi+220]
	124 Move r8, 0
	125 Move rcx, rbx
	126 Call 0x18063BD40, rcx, rdx, r8, r9
	127 Move rdx, [rdi+244]
	128 Move r8, 0
	129 Move rcx, rbx
	130 Call 0x18063BD40, rcx, rdx, r8, r9
	131 Move rdx, [rdi+248]
	132 Move r8, 0
	133 Move rcx, rbx
	134 Call 0x18063BD40, rcx, rdx, r8, r9
	135 Move rdx, [rdi+252]
	136 Move r8, 0
	137 Move rcx, rbx
	138 Call 0x18063BD40, rcx, rdx, r8, r9
	139 Move rdx, [rdi+256]
	140 Move r8, 0
	141 Move rcx, rbx
	142 Call 0x18063BD40, rcx, rdx, r8, r9
	143 Move rdx, [rdi+260]
	144 Move r8, 0
	145 Move rcx, rbx
	146 Call 0x18063BD40, rcx, rdx, r8, r9
	147 Move rdx, [rdi+264]
	148 Move r8, 0
	149 Move rcx, rbx
	150 Call 0x18063BD40, rcx, rdx, r8, r9
	151 Move xmm1, [rdi+268]
	152 Move r8, 0
	153 Move rcx, rbx
	154 Call 0x18060DAE0, rcx, rdx, r8, r9
	155 Move xmm1, [rdi+272]
	156 Move r8, 0
	157 Move rcx, rbx
	158 Call 0x18060DAE0, rcx, rdx, r8, r9
	159 Move rdx, [rdi+288]
	160 Move r8, 0
	161 Move rcx, rbx
	162 Call 0x18063BD40, rcx, rdx, r8, r9
	163 Move rdx, [rdi+292]
	164 Move r8, 0
	165 Move rcx, rbx
	166 Call 0x18063BD40, rcx, rdx, r8, r9
	167 Move rdx, [rdi+296]
	168 Move r8, 0
	169 Move rcx, rbx
	170 Call 0x18063BD40, rcx, rdx, r8, r9
	171 Move rdx, [rdi+300]
	172 Move r8, 0
	173 Move rcx, rbx
	174 Call 0x18063BD40, rcx, rdx, r8, r9
	175 Move rdx, [rdi+304]
	176 Move r8, 0
	177 Move rcx, rbx
	178 Call 0x18063BD40, rcx, rdx, r8, r9
	179 Move rdx, [rdi+308]
	180 Move r8, 0
	181 Move rcx, rbx
	182 Call 0x18063BAB0, rcx, rdx, r8, r9
	183 Move rdx, [rdi+309]
	184 Move r8, 0
	185 Move rcx, rbx
	186 Call 0x18063BAB0, rcx, rdx, r8, r9
	187 Move rdx, [rdi+310]
	188 Move r8, 0
	189 Move rcx, rbx
	190 Call 0x18063BAB0, rcx, rdx, r8, r9
	191 Move rdx, [rdi+311]
	192 Move r8, 0
	193 Move rcx, rbx
	194 Call 0x18063BAB0, rcx, rdx, r8, r9
	195 Move rdx, [rdi+312]
	196 Move r8, 0
	197 Move rcx, rbx
	198 Call 0x18063BAB0, rcx, rdx, r8, r9
	199 Move rdx, [rdi+313]
	200 Move r8, 0
	201 Move rcx, rbx
	202 Call 0x18063BAB0, rcx, rdx, r8, r9
	203 Move rdx, [rdi+316]
	204 Move r8, 0
	205 Move rcx, rbx
	206 Call 0x18063BD40, rcx, rdx, r8, r9
	207 Move rdx, [rdi+320]
	208 Compare rdx, 0
	209 JumpIfEqual {375}
	210 Move rdx, [rdx+368]
	211 Move r8, 0
	212 Move rcx, rbx
	213 Call 0x18063BAB0, rcx, rdx, r8, r9
	214 Move rdx, [rdi+320]
	215 Compare rdx, 0
	216 JumpIfEqual {375}
	217 Move rdx, [rdx+369]
	218 Move r8, 0
	219 Move rcx, rbx
	220 Call 0x18063BAB0, rcx, rdx, r8, r9
	221 Move rcx, [rdi+320]
	222 Compare rcx, 0
	223 JumpIfEqual {375}
	224 Move r9, [rcx]
	225 Move r8, r15
	226 Move rdx, rbx
	227 Move rax, [r9+648]
	228 Move r9, [r9+656]
	229 Call rax
	230 Move rdx, [rdi+280]
	231 Compare rdx, 0
	232 JumpIfEqual {375}
	233 Move rdx, [rdx+24]
	234 Move r8, 0
	235 Move rcx, rbx
	236 Call 0x18063BD40, rcx, rdx, r8, r9
	237 Move rcx, [rdi+280]
	238 Move rdx, 0
	239 Move rsi, 0
	240 Compare rcx, 0
	241 JumpIfEqual {375}
	242 Move r14, 32
	243 Move rax, rcx
	244 Move rbp, r14
	245 Compare rdx, [rcx+24]
	246 JumpIfGreaterOrEqual {266}
	247 Compare rax, 0
	248 JumpIfEqual {375}
	249 Compare rsi, [rax+24]
	250 JumpIfGreaterOrEqual {377}
	251 Move rcx, [rax+rbp]
	252 Compare rcx, 0
	253 JumpIfEqual {375}
	254 Move r9, 0
	255 Move r8, r15
	256 Move rdx, rbx
	257 Call MagnetItem.Serialize, rcx, rdx, r8
	258 Move rax, [rdi+280]
	259 Add rsi, rsi, 1
	260 Add rbp, rbp, 8
	261 Move rdx, rsi
	262 Move rcx, rax
	263 Compare rax, 0
	264 JumpIfEqual {375}
	265 Goto {245}
	266 Move rdx, [rdi+336]
	267 Compare rdx, 0
	268 JumpIfEqual {375}
	269 Move rdx, [rdx+24]
	270 Move r8, 0
	271 Move rcx, rbx
	272 Call 0x18063BD40, rcx, rdx, r8, r9
	273 Move rax, [rdi+336]
	274 Move rcx, 0
	275 Move rsi, 0
	276 Compare rax, 0
	277 JumpIfEqual {375}
	278 Nop 
	279 Compare rcx, [rax+24]
	280 JumpIfGreaterOrEqual {362}
	281 Move rax, [rdi+336]
	282 Compare rax, 0
	283 JumpIfEqual {375}
	284 Compare rsi, [rax+24]
	285 JumpIfGreaterOrEqual {377}
	286 Move rcx, typeof(UnityEngine.Object)
	287 Move rbp, [r14+rax]
	288 Compare [rcx+228], 0
	289 JumpIfNotEqual {291}
	290 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	291 Move r8, 0
	292 Move rdx, 0
	293 Move rcx, rbp
	294 Call Object.op_Inequality, rcx, rdx, r8
	295 Compare [0x184EEB4AD], 0
	296 Move r13, rax
	297 JumpIfNotEqual {303}
	298 LoadAddress rcx, [0x184C94098]
	299 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	300 LoadAddress rcx, [0x184C57A00]
	301 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	302 Move [0x184EEB4AD], 1
	303 Move r15, [rbx+16]
	304 Move rax, [0x184C57A00]
	305 Move stack:0x80, rax
	306 Compare r15, [rbx+8]
	307 JumpIfLessOrEqual {311}
	308 Move rcx, 0
	309 Call ThrowHelper.ThrowArgumentOutOfRangeException, rcx
	310 Move rax, stack:0x80
	311 Move rcx, [rax+32]
	312 Move r12, r15
	313 Add r12, r12, [rbx]
	314 Move rbp, [rbx+8]
	315 Move stack:0x2C, 0
	316 Compare [rcx+309], 1
	317 JumpIfNotEqual {319}
	318 Call 0x1804FC300, rcx, rdx, r8, r9
	319 Subtract rbp, rbp, r15
	320 Move stack:0x20, r12
	321 Compare [0x184EEB4C1], 0
	322 Move stack:0x28, rbp
	323 JumpIfNotEqual {329}
	324 LoadAddress rcx, [0x184C92D30]
	325 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	326 LoadAddress rcx, [0x184C57D70]
	327 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	328 Move [0x184EEB4C1], 1
	329 Compare rbp, 1
	330 JumpIfGreaterOrEqual {334}
	331 Move rdx, 0
	332 Move rcx, 28
	333 Call ThrowHelper.ThrowArgumentOutOfRangeException, rcx, rdx
	334 Move xmm0, stack:0x20
	335 LoadAddress rcx, stack:0x30
	336 Move rdx, [0x184C92D30]
	337 Move stack:0x30, xmm0
	338 Call 0x180721DA0, rcx, rdx
	339 Move [rax], r13
	340 Add [rbx+16], [rbx+16], 1
	341 Compare r13, 0
	342 JumpIfEqual {355}
	343 Move rax, [rdi+336]
	344 Compare rax, 0
	345 JumpIfEqual {375}
	346 Compare rsi, [rax+24]
	347 JumpIfGreaterOrEqual {377}
	348 Move rcx, [r14+rax]
	349 Compare rcx, 0
	350 JumpIfEqual {375}
	351 Move r8, stack:0x90
	352 Move r9, 0
	353 Move rdx, rbx
	354 Call MagnetItemController.Serialize, rcx, rdx, r8
	355 Move rax, [rdi+336]
	356 Add rsi, rsi, 1
	357 Add r14, r14, 8
	358 Move rcx, rsi
	359 Compare rax, 0
	360 JumpIfNotEqual {279}
	361 Goto {375}
	362 Move r14, stack:0x40
	363 Move r13, stack:0x48
	364 Move r12, stack:0x50
	365 Move rsi, stack:0x58
	366 Move rbp, stack:0x88
	367 ShiftStack 96
	368 Move r15, stack:0x0
	369 ShiftStack 8
	370 Move rdi, stack:0x0
	371 ShiftStack 8
	372 Move rbx, stack:0x0
	373 ShiftStack 8
	374 Return 
	375 Call 0x1804FEE20, rcx, rdx, r8, r9
	376 Interrupt 
	377 Call 0x1804FEE10, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
